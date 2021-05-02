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
    public partial class FormControl : Form
    {
        private bool isDragging = false;            //Флаг , для перемещения формы за панель
        private Point oldPos;                       //Поле текущих координат
        public FormControl()
        {
            InitializeComponent();
           formBoard = new FormBoard();            //Инициализация формы с результатами
        }
        FormBoard formBoard;                        //Переменная формы с результатами
        int team1_point=0;                          //Очки первой команды
        int team2_point=0;                          //Очки второй команды
        /// <summary>
        /// Событие , для добавления очков первой команде
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_team1plus1_Click(object sender, EventArgs e)
        {
            team1_point += Convert.ToInt32(((Button)(sender)).Tag); //Преобразование с последующим приблавлением поля Tag к очкам команды
            label_team1.Text = team1_point.ToString();    //Отображение результата
            formBoard.SetPoint_Team1(team1_point);        //Передача значения на табло
        }
        /// <summary>
        /// Событие , для добавления очков первой команде
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_team2plus1_Click(object sender, EventArgs e)
        {
            team2_point += Convert.ToInt32(((Button)(sender)).Tag);  //Преобразование с последующим приблавлением поля Tag к очкам команды
            label_team2.Text = team2_point.ToString();               //Отображение результата
            formBoard.SetPoint_Team2(team2_point);                   //Передача значения на табло
        }
        /// <summary>
        /// Событие , для отображения табло
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            formBoard.Visible = true;
        }
        /// <summary>
        /// Событие , для передачи названия команды на табло
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTeamName1_TextChanged(object sender, EventArgs e)
        {
            formBoard.SetName_Team1(textBoxTeamName1.Text);
        }
        /// <summary>
        /// Событие , для передачи названия команды на табло
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTeamName2_TextChanged(object sender, EventArgs e)
        {
            formBoard.SetName_Team2(textBoxTeamName2.Text);
        }
        /// <summary>
        /// Событие сброса результатов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_clear_Click(object sender, EventArgs e)
        {
            team1_point = 0;  //обнуление очков
            team2_point = 0;
            label_team1.Text = team1_point.ToString();  //Отображение
            label_team2.Text = team2_point.ToString();
            formBoard.SetPoint_Team1(team1_point);      //Передача на табло
            formBoard.SetPoint_Team2(team2_point);
        }
        /// <summary>
        /// Событие для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// События для перетаскивания формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>       
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)                                //Если флаг включен
            {
                Point tmp = new Point(Location.X, Location.Y);  //Создание новой точки
                tmp.X += e.X - oldPos.X;                        //Изменене координат по оси абцисс
                tmp.Y += e.Y - oldPos.Y;                        //Изменение координат по оси ординат
                Location = tmp;                                 //Присвоение новой позиции
            }
        }
        /// <summary>
        /// Событие , включающае флаг и сохранения текущей позиции для ее преобразования при нажатии на панель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;          //Если щелкнуть по  панели , то флаг включится
            oldPos = new Point();        //Объект старой позиции
            oldPos.X = e.X;               //сохранение координат
            oldPos.Y = e.Y;
        }
        /// <summary>
        /// Событие , отключающее флаг для перетаскивания формы за панель
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;             //Если мышка поднимется выше панели , флаг переключится
        }
    }
}
