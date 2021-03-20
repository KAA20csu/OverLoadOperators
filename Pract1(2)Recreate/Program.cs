﻿using System;

namespace Pract1_2_Recreate
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFrac = new Fraction(2, 3); // задана первая дробь
            var secondFrac = new Fraction(2, 5); // задана вторая дробь

            Console.WriteLine(firstFrac + secondFrac); // Сам вывод результата. "+" подсвечивается жёлтым, т.к имеет
            // иной функционал по отношению к стандартному оператору сложения.
        }
    }
    public class Fraction // Реализует перегрузку оператора сложения.
    {
        private int numerator; // числитель
        private int denominator; // знаменатель

        public Fraction(int Numer, int Denomin) // через конструктор мы присваиваем переменным значения.
            // В методе Main в круглых скобках мы передаём значения для этих переменных, а с помощью ключевого
            // слова this присваиваем числителю и знаменателю значения соответственно их расположению.
            // То есть, если в конструкторе Numer и Denomin поменять местами, в числитель запишется знаменатель,
            // а в знаменатель - числитель.
        {
            this.numerator = Numer;
            this.denominator = Denomin;
        }

        public static Fraction operator +(Fraction firstFrac, Fraction secondFrac)
            // Тут идёт сама перегрузка оператора. Грубо говоря, мы для обычного плюса создаем собственное поведение.
            // Мы хотим складывать дроби, и создаём логику для сложения (в подробности не вникаю, как складывать
            // дроби, мы все знаем с 3-4 класса. 
            // return возвращает полученное значение. Соответственно, когда в Main мы будем выводить в консоли
            // "Первая дробь" + "Вторая дробь", программа обратится именно к этому методу, и выдаст результат,
            // который мы описали в фигурных скобках этого метода.
            // Грубо говоря, мы переписали стандартную функцию сложения под свои нужды.
        {
            return new Fraction(firstFrac.numerator * secondFrac.denominator + secondFrac.numerator * firstFrac.denominator, firstFrac.denominator * secondFrac.denominator);
        }

        public override string ToString()
            // Данный метод просто выводит полученные значения. Этот класс стандартный, функционал его
            // не совсем мною усвоен, но если мы перегружаем методы, мы используем именно его, чтобы корректно вывести
            // полученные данные.
        {
            return $"{numerator}/{denominator}";
        }

        // Требуется дописать остальные операторы, аналогичные сложению. Всё пишется так же, только меняются знаки
        // и задаётся логика уже для деления/умножения/вычитания дробей (то что в скобках).
        // К примеру, чтобы умножить дробь, мы умножаем числитель первого и второго числа. Так же знаменатель, и всё это
        // помещается в return new Fraction(операция умножения/вычитания/деления);

    }
}
