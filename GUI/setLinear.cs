using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public class setLinear
    {
        public static void SetLinearGradient(Button btn, string hexColor1, string hexColor2)
        {
            // Chuyển đổi mã màu hex thành đối tượng Color
            Color color1 = ColorTranslator.FromHtml(hexColor1);
            Color color2 = ColorTranslator.FromHtml(hexColor2);

            // Tạo đối tượng LinearGradientBrush
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(
                btn.ClientRectangle,
                color1,
                color2,
                LinearGradientMode.Horizontal); // Có thể thay đổi hướng dải màu tại đây

            // Thiết lập màu nền của Panel là dải màu linear
            btn.BackColor = Color.Transparent; // Đặt màu nền trong suốt để thấy rõ dải màu
            btn.BackgroundImage = new Bitmap(btn.Width, btn.Height);
            using (Graphics g = Graphics.FromImage(btn.BackgroundImage))
            {
                g.FillRectangle(linearGradientBrush, btn.ClientRectangle);
            }
        }
    }
}
