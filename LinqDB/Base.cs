namespace LinqDB
{
    public abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string post;
        public int salary;
        public int exWorks;
    }

    class Employee1 : Person
    {
        public Employee1()
        {
            FirstName = "Дмитрий";
            LastName = "Васильев";
            post = "Старший продавец";
            salary = 30000;
            exWorks = 20;
        }
    }

    class Employee2 : Person
    {
        public Employee2()
        {
            FirstName = "Василий";
            LastName = "Деревенькин";
            post = "Продавец";
            salary = 22000;
            exWorks = 50;
        }
    }

    class Employee3 : Person
    {
        public Employee3()
        {
            FirstName = "Алексей";
            LastName = "Горбунов";
            post = "Продавец";
            salary = 20000;
            exWorks = 80;
        }
    }
}
