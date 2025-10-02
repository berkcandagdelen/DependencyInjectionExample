using System;
using DependencyInjectionExample;
using DependencyInjectionExample.Models;

class Program
{
    static void Main(string[] args)
    {
        // 1) Concrete implementasyon üret (runtime’da seçildi)
        ITeacher teacher = new Teacher("Berk", "Dağdelen");

        // 2) Bağımlılığı enjekte et
        var classRoom = new ClassRoom(teacher);

        // 3) Kullan
        Console.WriteLine(classRoom.GetTeacherInfo());

        // Kapanmadan gör
        if (System.Diagnostics.Debugger.IsAttached)
            Console.ReadLine();
    }
}
