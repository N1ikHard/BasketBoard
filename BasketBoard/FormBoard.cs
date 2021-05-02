using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasketBoard
{
    public partial class FormBoard : Form
    {
        private bool isDragging = false;    //Флаг , для перемещения формы за панель
        private Point oldPos;               //Поле текущих координат

        public FormBoard()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод присвоения первой команде очков
        /// </summary>
        /// <param name="point"></param>
        public void SetPoint_Team1(int point)
        {
            label_team1_points.Text = point.ToString();
        }
        /// <summary>
        /// Метод присвоения второй команде очков
        /// </summary>
        /// <param name="point"></param>
        public void SetPoint_Team2(int point)
        {
            label_team2_points.Text = point.ToString();
        }
        /// <summary>
        /// Метод установки названия команды 1
        /// </summary>
        /// <param name="name"></param>
        public void SetName_Team1(string name)
        {
            label_team1_name.Text = name;
        }
        /// <summary>
        /// Метод установки названия команды 2
        /// </summary>
        /// <param name="name"></param>
        public void SetName_Team2(string name)
        {
            label_team2_name.Text = name;
        }
        /// <summary>
        /// Событие скрытия табла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2_Click(object sender, EventArgs e)
        {
            Hide();
        }
        /// <summary>
        /// Событие , включающае флаг и сохранения текущей позиции для ее преобразования при нажатии на панель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.isDragging = true;
            this.oldPos = new Point();
            this.oldPos.X = e.X;
            this.oldPos.Y = e.Y;
        }
        /// <summary>
        /// Событие , отключающее флаг для перетаскивания формы за панель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.isDragging)
            {
                Point tmp = new Point(this.Location.X, this.Location.Y);
                tmp.X += e.X - this.oldPos.X;
                tmp.Y += e.Y - this.oldPos.Y;
                this.Location = tmp;
            }
        }
        /// <summary>
        /// События для перетаскивания формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDragging = false;
        }
    }
}
