using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class RabotaForm : Form
    {
        public RabotaForm()
        {
            // Установка свойств формы
            this.Text = "Схема системы передачи с временным разделением";
            this.Size = new Size(850, 300);

            // Подписываемся на событие Paint формы
            this.Paint += new PaintEventHandler(RabotaForm_Paint);
        }

        private void RabotaForm_Paint(object sender, PaintEventArgs e)
        {
            // Создаем объект Graphics для рисования
            Graphics g = e.Graphics;

            // Определяем координаты и размеры первого прямоугольника
            int x1 = 50;
            int y1 = 50;
            int width1 = 60;
            int height1 = 40;

            // Определяем координаты и размеры второго прямоугольника
            int x2 = x1 + 70;
            int y2 = y1;
            int width2 = 60;
            int height2 = 40;

            // Определяем координаты и размеры третьего прямоугольника
            int x3 = x2 + 70;
            int y3 = y2;
            int width3 = 60;
            int height3 = 40;

            // Определяем координаты и размеры первого зеленого прямоугольника
            int x4 = x1;
            int y4 = y1 + 70;
            int width4 = 60;
            int height4 = 40;

            // Определяем координаты и размеры второго зеленого прямоугольника
            int x5 = x4 + 70;
            int y5 = y4;
            int width5 = 60;
            int height5 = 40;

            // Определяем координаты и размеры третьего зеленого прямоугольника
            int x6 = x5 + 140;
            int y6 = y5;
            int width6 = 60;
            int height6 = 40;

            // Определяем координаты и размеры первого красного прямоугольника
            int x7 = x4;
            int y7 = y4 + 70;
            int width7 = 60;
            int height7 = 40;

            // Определяем координаты и размеры второго красного прямоугольника
            int x8 = x7 + 140;
            int y8 = y7;
            int width8 = 60;
            int height8 = 40;

            // Определяем координаты и размеры третьего красного прямоугольника
            int x9 = x8 + 70;
            int y9 = y8;
            int width9 = 60;
            int height9 = 40;

            // Определяем координаты и размеры четвертого красного прямоугольника
            int x10 = x9 + 70;
            int y10 = y9;
            int width10 = 60;
            int height10 = 40;

            // Определяем координаты и размеры первого голубого прямоугольника
            int x11 = x1 + 300;
            int y11 = y1;
            int width11 = 60;
            int height11 = 110;

            // Определяем координаты и размеры второго голубого прямоугольника
            int x12 = x11 + 100;
            int y12 = y11;
            int width12 = 60;
            int height12 = 110;

            // Определяем координаты и размеры первого фиолетового (зеркальный)
            int x13 = x12 + 70;
            int y13 = y12;
            int width13 = 60;
            int height13 = 40;

            // Определяем координаты и размеры второго фиолетового (зеркальный)
            int x14 = x13 + 140;
            int y14 = y13;
            int width14 = 60;
            int height14 = 40;

            // Определяем координаты и размеры третьего фиолетового (зеркальный)
            int x15 = x14 + 70;
            int y15 = y14;
            int width15 = 60;
            int height15 = 40;

            // Определяем координаты и размеры первого зеленого (зеркальный)
            int x16 = x12 + 140;
            int y16 = y12 + 70;
            int width16 = 60;
            int height16 = 40;

            // Определяем координаты и размеры второго зеленего (зеркальный)
            int x17 = x16 + 70;
            int y17 = y16;
            int width17 = 60;
            int height17 = 40;

            // Определяем координаты и размеры третьего зеленего (зеркальный)
            int x18 = x17 + 70;
            int y18 = y17;
            int width18 = 60;
            int height18 = 40;

            // Определяем координаты и размеры первого красного прямоугольника
            int x19 = x12;
            int y19 = y12 + 140;
            int width19 = 60;
            int height19 = 40;

            // Определяем координаты и размеры первого красного прямоугольника
            int x20 = x19 + 70;
            int y20 = y19;
            int width20 = 60;
            int height20 = 40;

            // Определяем координаты и размеры первого красного прямоугольника
            int x21 = x20 + 70;
            int y21 = y20;
            int width21 = 60;
            int height21 = 40;



            // Рисуем прямоугольники и текст
            using (SolidBrush brush = new SolidBrush(Color.Purple))
            using (SolidBrush textBrush = new SolidBrush(Color.Black))
            using (SolidBrush greenBrush = new SolidBrush(Color.Green))
            using (SolidBrush redBrush = new SolidBrush(Color.Red))
            {
                // Рисуем первый прямоугольник
                g.FillRectangle(brush, x1, y1, width1, height1);
                DrawText(g, textBrush, "Прд 1", x1, y1, width1, height1);

                // Рисуем второй прямоугольник
                g.FillRectangle(brush, x2, y2, width2, height2);
                DrawText(g, textBrush, "Фнч 1", x2, y2, width2, height2);

                // Рисуем третий прямоугольник
                g.DrawRectangle(Pens.Purple, x3, y3, width3, height3);
                DrawText(g, textBrush, "К1", x3, y3, width3, height3);

                // Рисуем первый зеленый прямоугольник
                g.FillRectangle(greenBrush, x4, y4, width4, height4);
                DrawText(g, textBrush, "Прд 2", x4, y4, width4, height4);

                // Рисуем второй зеленый прямоугольник
                g.FillRectangle(greenBrush, x5, y5, width5, height5);
                DrawText(g, textBrush, "Фнч 2", x5, y5, width5, height5);

                // Рисуем третий зеленый прямоугольник
                g.DrawRectangle(Pens.Green, x6, y6, width6, height6);
                DrawText(g, textBrush, "К2", x6, y6, width6, height6);

                // Рисуем первый красный прямоугольник
                g.DrawRectangle(Pens.Red, x7, y7, width7, height7);
                DrawText(g, textBrush, "ГЗ", x7, y7, width7, height7);

                // Рисуем второй красный прямоугольник
                g.DrawRectangle(Pens.Red, x8, y8, width8, height8);
                DrawText(g, textBrush, "P1", x8, y8, width8, height8);

                // Рисуем третий красный прямоугольник
                g.DrawRectangle(Pens.Red, x9, y9, width9, height9);
                DrawText(g, textBrush, "P2", x9, y9, width9, height9);

                // Рисуем четвертый красный прямоугольник
                g.DrawRectangle(Pens.Red, x10, y10, width10, height10);
                DrawText(g, textBrush, "ЦС", x10, y10, width10, height10);

                // Рисуем первый голубой прямоугольник
                g.DrawRectangle(Pens.Blue, x11, y11, width11, height11);
                DrawText(g, textBrush, "", x11, y11, width11, height11);

                // Рисуем второй голубой прямоугольник
                g.DrawRectangle(Pens.Blue, x12, y12, width12, height12);
                DrawText(g, textBrush, "", x12, y12, width12, height12);

                // Рисуем первый (Зеркальный) прямоугольник
                g.DrawRectangle(Pens.Purple, x13, y13, width13, height13);
                DrawText(g, textBrush, "К1", x13, y13, width13, height13);

                // Рисуем второй (Зеркальный) прямоугольник
                g.FillRectangle(brush, x14, y14, width14, height14);
                DrawText(g, textBrush, "Фнч 1", x14, y14, width14, height14);

                // Рисуем третий (Зеркальный) прямоугольник
                g.FillRectangle(brush, x15, y15, width15, height15);
                DrawText(g, textBrush, "Пр 1", x15, y15, width15, height15);

                // Рисуем первый зеленый (Зеркальный) прямоугольник
                g.DrawRectangle(Pens.Green, x16, y16, width16, height16);
                DrawText(g, textBrush, "К2", x16, y16, width16, height16);

                // Рисуем второй зеленый (Зеркальный) прямоугольник
                g.FillRectangle(greenBrush, x17, y17, width17, height17);
                DrawText(g, textBrush, "Фнч 2", x17, y17, width17, height17);

                // Рисуем третий зеленый (Зеркальный) прямоугольник
                g.FillRectangle(greenBrush, x18, y18, width18, height18);
                DrawText(g, textBrush, "Пр 2", x18, y18, width18, height18);

                // Рисуем первый красный (Зеркальный) прямоугольник
                g.DrawRectangle(Pens.Red, x19, y19, width19, height19);
                DrawText(g, textBrush, "ПЦС", x19, y19, width19, height19);

                // Рисуем второй красный (Зеркальный) прямоугольник
                g.DrawRectangle(Pens.Red, x20, y20, width20, height20);
                DrawText(g, textBrush, "P1", x20, y20, width20, height20);

                // Рисуем третий красный (Зеркальный) прямоугольник
                g.DrawRectangle(Pens.Red, x21, y21, width21, height21);
                DrawText(g, textBrush, "P2", x21, y21, width21, height21);

                using (Pen purplePen = new Pen(Color.Purple, 2))
                using (Pen greenPen = new Pen(Color.Green, 2))
                using (Pen redPen = new Pen(Color.Red, 2))
                {
                    // Определяем координаты точек для соединения
                    Point rightSideOfRect1 = new Point(x1 + width1, y1 + height1 / 2);
                    Point leftSideOfRect2 = new Point(x2, y2 + height2 / 2);
                    Point rightSideOfRect2 = new Point(x2 + width2, y2 + height2 / 2);
                    Point leftSideOfRect3 = new Point(x3, y3 + height3 / 2);
                    Point rightSideOfRect3 = new Point(x3 + width3, y3 + height3 / 2);
                    Point rightSideOfRect4 = new Point(x4 + width4, y4 + height4 / 2);
                    Point leftSideOfRect5 = new Point(x5, y5 + height5 / 2);
                    Point rightSideOfRect5 = new Point(x5 + width5, y5 + height5 / 2);
                    Point leftSideOfRect6 = new Point(x6, y6 + height6 / 2);
                    Point leftSideOfRect7 = new Point(x11, y11 + height11 / 2);

                    // Рисуем линии
                    DrawConnectingLine(g, purplePen, rightSideOfRect1, leftSideOfRect2);
                    DrawConnectingLine(g, purplePen, rightSideOfRect2, leftSideOfRect3);
                    DrawConnectingLine(g, purplePen, rightSideOfRect3, leftSideOfRect7);

                    // Зеленые линии
                    Point rightSideOfRect4Green = new Point(x4 + width4, y4 + height4 / 2);
                    Point leftSideOfRect5Green = new Point(x5, y5 + height5 / 2);
                    Point rightSideOfRect5Green = new Point(x5 + width5, y5 + height5 / 2);
                    Point leftSideOfRect6Green = new Point(x6, y6 + height6 / 2);

                    DrawConnectingLine(g, greenPen, rightSideOfRect4Green, leftSideOfRect5Green);
                    DrawConnectingLine(g, greenPen, rightSideOfRect5Green, leftSideOfRect6Green);

                    // Красные линии
                    Point rightSideOfRect7Red = new Point(x7 + width7, y7 + height7 / 2);
                    Point leftSideOfRect8Red = new Point(x8, y8 + height8 / 2);
                    Point rightSideOfRect8Red = new Point(x8 + width8, y8 + height8 / 2);
                    Point leftSideOfRect9Red = new Point(x9, y9 + height9 / 2);
                    Point rightSideOfRect9Red = new Point(x9 + width9, y9 + height9 / 2);
                    Point leftSideOfRect10Red = new Point(x10, y10 + height10 / 2);

                    DrawConnectingLine(g, redPen, rightSideOfRect7Red, leftSideOfRect8Red);
                    DrawConnectingLine(g, redPen, rightSideOfRect8Red, leftSideOfRect9Red);
                    DrawConnectingLine(g, redPen, rightSideOfRect9Red, leftSideOfRect10Red);

                    // Зеленая линия от правой стороны К2 к левой стороне первого голубого прямоугольника
                    Point rightSideOfRect6Green = new Point(x6 + width6, y6 + height6 / 2);
                    Point leftSideOfRect11Blue = new Point(x11, y11 + height11 / 2);

                    DrawConnectingLine(g, greenPen, rightSideOfRect6Green, leftSideOfRect11Blue);

                    // Красные линии
                    Point topOfRect8Red = new Point(x8 + width8 / 2, y8);
                    Point bottomOfRect9Red = new Point(x9 + width9 / 2, y9 + height9);
                    Point topOfRect10Red = new Point(x10 + width10 / 2, y10);
                    Point topOfRect7Red = new Point(x7 + width7 / 2, y7);
                    Point bottomOfRect11Blue = new Point(x11 + width11 / 2, y11 + height11);

                    DrawConnectingLine(g, redPen, topOfRect10Red, bottomOfRect11Blue);

                    // Соединение правой стороны первого голубого прямоугольника с левой стороной второго голубого прямоугольника
                    Point rightSideOfRect12Blue = new Point(x12 + width12, y12 + height12 / 2);
                    Point leftSideOfRect13Blue = new Point(x13, y13 + height13 / 2);

                    DrawConnectingLine(g, purplePen, rightSideOfRect12Blue, leftSideOfRect13Blue);

                    // Определение координаты точек для соединения синих прямоугольников
                    Point rightSideOfRect11Blue = new Point(x11 + width11, y11 + height11 / 2);
                    Point leftSideOfRect12Blue = new Point(x12, y12 + height12 / 2);

                    // Рисуем линию между правой стороной первого синего прямоугольника и левой стороной второго синего прямоугольника
                    DrawConnectingLine(g, purplePen, rightSideOfRect11Blue, leftSideOfRect12Blue);

                    // Определение координат точек для соединения
                    Point bottomOfRect3 = new Point(x3 + width3 / 2, y3 + height3);
                    // Используем ранее определенную точку topOfRect8Red
                    DrawConnectingLine(g, redPen, bottomOfRect3, topOfRect8Red);

                    // Определение верхней части третьего красного прямоугольника
                    Point topOfRect9Red = new Point(x9 + width9 / 2, y9);

                    // Определение нижней части третьего зеленого прямоугольника
                    Point bottomOfRect6Green = new Point(x6 + width6 / 2, y6 + height6);

                    // Рисуем зеленую линию между третьим красным и третьим зеленым прямоугольниками
                    DrawConnectingLine(g, redPen, topOfRect9Red, bottomOfRect6Green);

                    // Определение точек для соединения
                    Point leftSideOfRect13Purple = new Point(x13, y13 + height13 / 2);
                    Point rightSideOfRect13Purple = new Point(x13 + width13, y13 + height13 / 2);
                    Point leftSideOfRect14Purple = new Point(x14, y14 + height14 / 2);
                    Point rightSideOfRect14Purple = new Point(x14 + width14, y14 + height14 / 2);
                    Point leftSideOfRect15Purple = new Point(x15, y15 + height15 / 2);
                    Point rightSideOfRect15Purple = new Point(x15 + width15, y15 + height15 / 2);
                    Point leftSideOfRect16Green = new Point(x16, y16 + height16 / 2);
                    Point rightSideOfRect16Green = new Point(x16 + width16, y16 + height16 / 2);
                    Point leftSideOfRect17Green = new Point(x17, y17 + height17 / 2);
                    Point rightSideOfRect17Green = new Point(x17 + width17, y17 + height17 / 2);
                    Point leftSideOfRect18Green = new Point(x18, y18 + height18 / 2);
                    Point rightSideOfRect18Green = new Point(x18 + width18, y18 + height18 / 2);
                    Point leftSideOfRect19Red = new Point(x19, y19 + height19 / 2);
                    Point rightSideOfRect19Red = new Point(x19 + width19, y19 + height19 / 2);
                    Point leftSideOfRect20Red = new Point(x20, y20 + height20 / 2);
                    Point rightSideOfRect20Red = new Point(x20 + width20, y20 + height20 / 2);
                    Point leftSideOfRect21Red = new Point(x21, y21 + height21 / 2);

                    // Рисуем линии
                    DrawConnectingLine(g, purplePen, rightSideOfRect12Blue, leftSideOfRect13Purple);
                    DrawConnectingLine(g, purplePen, rightSideOfRect13Purple, leftSideOfRect14Purple);
                    DrawConnectingLine(g, purplePen, rightSideOfRect14Purple, leftSideOfRect15Purple);

                    DrawConnectingLine(g, greenPen, rightSideOfRect16Green, leftSideOfRect17Green);
                    DrawConnectingLine(g, greenPen, rightSideOfRect17Green, leftSideOfRect18Green);

                    DrawConnectingLine(g, redPen, rightSideOfRect19Red, leftSideOfRect20Red);
                    DrawConnectingLine(g, redPen, rightSideOfRect20Red, leftSideOfRect21Red);

                    

                    // Определение точек для соединения
                    Point bottomOfRect12Blue = new Point(x12 + width12 / 2, y12 + height12);
                    Point topOfRect19Red = new Point(x19 + width19 / 2, y19);

                    Point bottomOfRect19Red = new Point(x19 + width19 / 2, y19 + height19);
                    Point topOfRect20Red = new Point(x20 + width20 / 2, y20);

                    Point bottomOfRect20Red = new Point(x20 + width20 / 2, y20 + height20);
                    Point topOfRect13Purple = new Point(x13 + width13 / 2, y13);

                    Point bottomOfRect13Purple = new Point(x13 + width13 / 2, y13 + height13);
                    Point topOfRect21Red = new Point(x21 + width21 / 2, y21);

                    Point bottomOfRect21Red = new Point(x21 + width21 / 2, y21 + height21);
                    Point topOfRect16Green = new Point(x16 + width16 / 2, y16);

                    Point bottomOfRect16Green = new Point(x16 + width16 / 2, y16 + height16);

                    // Рисуем линии
                    DrawConnectingLine(g, redPen, bottomOfRect12Blue, topOfRect19Red);

                    DrawConnectingLine(g, redPen, topOfRect20Red, bottomOfRect13Purple);

                    DrawConnectingLine(g, redPen, topOfRect21Red, bottomOfRect16Green);

                    Point rightOfRect12Blue = new Point(x12 + width12, y12 + height12 / 2);
                    Point leftOfRect16Green = new Point(x16, y16 + height16 / 2);
                    DrawConnectingLine(g, greenPen, rightOfRect12Blue, leftOfRect16Green);
                }
            }
        }

        private void DrawConnectingLine(Graphics g, Pen pen, Point start, Point end)
        {
            // Рисуем линию
            g.DrawLine(pen, start, end);
        }

        private void DrawText(Graphics g, SolidBrush textBrush, string text, int x, int y, int width, int height)
        {
            Font font = new Font("Arial", 10);
            float textX = x + (width - g.MeasureString(text, font).Width) / 2;
            float textY = y - g.MeasureString(text, font).Height;
            g.DrawString(text, font, textBrush, textX, textY);
            font.Dispose();
        }

        [STAThread]
        static void MyMain()
        {
            // Создаем экземпляр формы и запускаем приложение
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DiagramForm());
        }
    }
}
