using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{

    class Person //класс личности
    {
        private string _name; //приватное поле для имени
        private string _surname; //приватное поле для фамилии
        

        public string Name //свойство для имени
        {
            //Сеттер и геттер для имени
            //Присваиваем через сеттеры и геттеры полям значения через свойство
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string Surname //свойство для фамилии
        {
            //Сеттер и геттер для фамилии
            //Присваиваем через сеттеры и геттеры полям значения через свойство
            set
            {
                _surname = value;
            }
            get
            {
                return _surname;
            }
        }
        
        public int Age { get; set; } //автосвойство. Автоматически создается поле для свойства. Автоматически прописываются сеттер и геттер для этого поля

        public Person(string name, string surname) //конструктор
        {
            _name = name;
            _surname = surname;
        }

        public void PreprocessProperties() // метод для препроцессинга строк от точек и запятых
        {
            EditString editString; //объявление делегата
            ActionCollection actionCollection = new ActionCollection();

            editString = actionCollection.RemoveComma; // присваиваем делегату ссылку на метод
            _name = DelegateAction(editString, _name); //выполняем через метод DelegateAction 
            _surname = DelegateAction(editString, _surname);

            editString = actionCollection.RemoveDots;
            _name = DelegateAction(editString, _name);
            _surname = DelegateAction(editString, _surname);
        }

        static string DelegateAction(EditString action, string inputString) // Выполнение делегата action. Передача самого делегата и аргумента для делегата
        {
            string result = action(inputString);
            return result;
        }
    }
}
