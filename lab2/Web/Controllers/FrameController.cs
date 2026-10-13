using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.Json;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrameController : ControllerBase
    {
        [HttpPost("calculate")]
        public IActionResult Calculate()
        {

            string width;
            string height;
            string border;
            bool isFormRequest = Request.HasFormContentType;

            if (isFormRequest)
            {
                // 表单请求
                var form = Request.Form;

                width = form["width"].ToString();
                height = form["height"].ToString();
                border = form["border"].ToString();
            }
            else if (Request.ContentType?.Split(';')[0].Trim().Equals("application/json",StringComparison.OrdinalIgnoreCase) == true)
            {
                // JSON 请求
                JsonDocument json;

                try
                {
                    json = JsonDocument.Parse(Request.BodyReader.AsStream());
                }
                catch (JsonException)
                {
                    return BadRequest(new { error = "JSON 格式错误" });
                }

                using (json)
                {
                    if (json.RootElement.ValueKind != JsonValueKind.Object ||
                        !json.RootElement.TryGetProperty("width", out JsonElement widthElement) ||
                        !json.RootElement.TryGetProperty("height", out JsonElement heightElement) ||
                        !json.RootElement.TryGetProperty("border", out JsonElement borderElement))
                    {
                        return BadRequest(new { error = "缺少必要参数" });
                    }

                    width = widthElement.ToString();
                    height = heightElement.ToString();
                    border = borderElement.ToString();
                }
            }
            else
            {
                return StatusCode(415, new
                {
                    error = "不支持的 Content-Type"
                });
            }

            if (!double.TryParse(width, NumberStyles.Float,CultureInfo.InvariantCulture, out double w) || !double.TryParse(height, NumberStyles.Float, CultureInfo.InvariantCulture, out double h) || !double.TryParse(border, NumberStyles.Float,CultureInfo.InvariantCulture, out double b))
            {
                return BadRequest(new
                {
                    error = "请输入有效数字"
                });
            }
            else if (!double.IsFinite(w) || !double.IsFinite(h) || !double.IsFinite(b))
            {
                return BadRequest(new
                {
                    error = "输入不能为无穷数值"
                });
            }
            else if (w <= 0 || w > 10000 || h <= 0 || h > 10000 || b <= 0)
            {
                return BadRequest(new
                {
                    error = "宽高必须在 (0,10000] 范围内，边框必须大于0"
                });
            }
            else if (b >= w / 2 || b >= h / 2)
            {
                return BadRequest(new
                {
                    error = "边框过宽，内部展示区域必须大于0"
                });
            }

            double innerWidth = w - 2 * b;
            double innerHeight = h - 2 * b;

            double usableArea = innerWidth * innerHeight;

            double outerArea = w * h;

            double borderArea = outerArea - usableArea;

            double outerPerimeter = 2 * (w + h);

            if (isFormRequest)
            {
                return Ok(new
                {
                    message = $"displayArea：{usableArea:F2} 平方厘米；borderArea：{borderArea:F2} 平方厘米；outerPerimeter：{outerPerimeter:F2} 厘米"
                });
            }
            else
            {
                return Ok(new
                {
                    displayArea = $"displayArea：{usableArea:F2} 平方厘米",
                    borderArea = $"borderArea：{borderArea:F2} 平方厘米",
                    outerPerimeter = $"outerPerimeter：{outerPerimeter:F2} 厘米"
                });
            }
            
        }
    }
}
