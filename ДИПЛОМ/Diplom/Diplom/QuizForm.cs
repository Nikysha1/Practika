using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Сделал комментарий
namespace Diplom
{
    public partial class QuizForm : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;

        private Label questionLabel;
        private List<RadioButton> answerRadioButtons;
        private Button nextButton;

        public QuizForm()
        {
            InitializeComponent();
            InitializeQuestions();
            LoadQuestion();
        }

        private void InitializeQuestions()
        {
            // Создаем 10 вопросов и варианты ответов
            questions = new List<Question>
            {
                new Question("Назначение задающего генератора на передаче?", new List<string> { "Вырабатывает токи управляющих частот", "Вырабатывает токи с тактовой частотой, управляет работой РИ", "Вырабатывает токи сигнальных частот", "Вырабатывает токи несущей частоты" }, 0),
                new Question("Назначение  распределителя импульсов  P1 и P2  на передаче?", new List<string> { "Управляет работой оборудования линейного тракта", "Управляет работой задающего генератора", "Управляет работой ключей К1 и К2", "Формирует линейный сигнал" }, 2),
                new Question("Назначение оборудования линейного тракта?", new List<string> { "Управляет работой ключей", "Преобразует сигнал из АИМ-1 в АИМ -2", "Управляет работой РИ1 и РИ2", "Ограничвает сигнал по спектру" }, 1),
                new Question("Название ключей К1 и К2 на приеме?", new List<string> { "Управляют работой фильтра нижних частот", "Выделяют из группового сигнала импульсы  своего канала", "Управляют работой  РИ1 и РИ2 на приеме", "Согласуют работу ОЛТ с работой станционного оборудования " }, 2),
                new Question("Назначение ФНЧ на приеме?", new List<string> { "Улучшают качество принимаемого сигнала", "Уменьшают шумы квантования", "Выделяют из спектра  АИМ сигнала НЧ составляющую", "Подавляет токи несущей частоты" }, 2),
                new Question("Назначение приемника цикловой синхронизации ПЦС?", new List<string> { "Управляет работой оборудования линейного тракта", "Управляет работой ключей К1 и К2", "Ограничивает передаваемый сигнал по спектру", "Управляет работой распределителей импульсов P1 и P2 " }, 3),
                new Question("Почему в аппаратуре связи с ИКМ в телефонном канале fд= 8кГц?", new List<string> { "С уменьшением частоты возрастают шумы", "Предусмотрен частотный  запас на расфильтровку", "Низкие требования к генераторному оборудованию ", "Невозможность повысить частоту дискретизации" }, 0),
                new Question("Определить частоту дискретизации для сигнала со спектром  16-30 кГц?", new List<string> { "fд= 12 кГц", "fд= 8 кГц", "fд= 68 кГц", "fд= 60 кГц" }, 3),
                new Question("Назначение ФНЧ на передаче?", new List<string> { "Улучшают качество передачи", "Уменьшают помехи", "Ограничивают спектр передаваемого сигнала", "Уменьшают уровень шумов" }, 2),
                new Question("Назначение ключей К1 и К2 на передаче?", new List<string> { "Вырабатывают импульсную последовательность с частотой fд", "Моделируют передаваемый сигнал на амплитуде ", "Управляют работой оборудования линейного тракта", "Управляют работой распределителей импульсов " }, 3),
                // Добавьте еще вопросы аналогичным образом
            };
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                Question currentQuestion = questions[currentQuestionIndex];

                // Очищаем предыдущие элементы управления
                ClearControls();

                // Добавляем варианты ответов в виде RadioButton
                answerRadioButtons = new List<RadioButton>();
                foreach (string option in currentQuestion.Options)
                {
                    RadioButton radioButton = new RadioButton
                    {
                        Text = option,
                        Dock = DockStyle.Top,
                        Font = new Font("Times New Roman", 14) // Шрифт
                    };

                    radioButton.CheckedChanged += RadioButton_CheckedChanged; // Добавляем обработчик события
                    answerRadioButtons.Add(radioButton);
                    groupBoxQuestion.Controls.Add(radioButton);
                }

                // Добавляем кнопку "Далее"
                nextButton = new Button
                {
                    Text = "Далее",
                    Dock = DockStyle.Top,
                    Font = new Font("Times New Roman", 14), // Шрифт
                    Height = 40 // Увеличиваем высоту кнопки
                };

                nextButton.Click += NextButton_Click;
                groupBoxQuestion.Controls.Add(nextButton);

                // Добавляем текст вопроса
                questionLabel = new Label
                {
                    Text = currentQuestion.Text,
                    Dock = DockStyle.Top,
                    Font = new Font("Times New Roman", 14, FontStyle.Bold) // Жирный шрифт
                };

                groupBoxQuestion.Controls.Add(questionLabel);
            }
            else
            {
                // Вопросы закончились - выводим статистику
                ShowResults();
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Сохраняем ответ пользователя при изменении состояния RadioButton
            RadioButton radioButton = (RadioButton)sender;
            int selectedOptionIndex = answerRadioButtons.IndexOf(radioButton);
            questions[currentQuestionIndex].UserAnswerIndex = selectedOptionIndex;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Переходим к следующему вопросу
            currentQuestionIndex++;

            // Загружаем следующий вопрос
            LoadQuestion();
        }

        private void ShowResults()
        {
            // Выводим статистику
            int correctAnswers = questions.Count(q => q.CorrectAnswerIndex == q.UserAnswerIndex);
            int totalQuestions = questions.Count;

            double score = (double)correctAnswers / totalQuestions * 100;

            string resultMessage = $"Тест завершен!\nПравильных ответов: {correctAnswers}/{totalQuestions}\nОценка: {GetGrade(score)}";
            MessageBox.Show(resultMessage);
        }

        private string GetGrade(double score)
        {
            if (score >= 90)
                return "Отлично";
            else if (score >= 70)
                return "Хорошо";
            else if (score >= 50)
                return "Удовлетворительно";
            else
                return "Неудовлетворительно";
        }

        private void ClearControls()
        {
            groupBoxQuestion.Controls.Clear();
        }
    }

    public class Question
    {
        public string Text { get; }
        public List<string> Options { get; }
        public int CorrectAnswerIndex { get; }
        public int UserAnswerIndex { get; set; }

        public Question(string text, List<string> options, int correctAnswerIndex)
        {
            Text = text;
            Options = options;
            CorrectAnswerIndex = correctAnswerIndex;
            UserAnswerIndex = -1; // -1 означает, что ответ еще не выбран
        }
    }
}
