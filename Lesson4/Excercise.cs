using System.ComponentModel.DataAnnotations;

namespace Lesson04;

class Excercise
{
    static void Main(string[] args)
    {
        // Console.Write("Enter value of a: ");
        // var a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter value of b: ");
        // var b = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter value of c: ");
        // var c = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($" {a}x2 + {b}x + {c} = 0");

        // Console.Write("Enter value of length: ");
        // var length = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Enter value of width: ");
        // var width = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"{length}*{width} = {length*width}");
        // Console.WriteLine($"({length}+{width})x2 = {(length+width)*2}");

        // const double Pi = 3.14;
        // Console.Write("Enter value of radius: ");
        // var r = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"{r}x2xPi = {r*2*Pi}");
        // Console.WriteLine($"{r}x{r}xPi = {Math.Pow(r,2)*Pi}");

        //BMI = (cân nặng)/(chiều cao^2)
        // Console.Write("Enter your weight(kg): ");
        // var w = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Enter your height(m): ");
        // var h = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine($"Your BMI index : {(w)/(h*h)}");

        /*Console.Write("Enter number1: ");
        var number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number2: ");
        var number2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter number3: ");
        var number3 = Convert.ToDouble(Console.ReadLine());
        double Max = 0;
        //C1
        if(Max<number1) Max = number1;
        if(Max<number2) Max = number2;
        if(Max<number3) Max = number3;
        //C2
        // Max = number1>number2?number1:number2;
        // Max = Max>number3?Max:number3;
        Console.WriteLine($"Max number is {Max}");*/

        // //Bai1: Tinh chi so BMI
        // //BMI = (cân nặng)/(chiều cao^2)
        // Console.Write("Nhap can nang cua ban(kg): ");
        // var w = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap chieu cao cua ban(m): ");
        // var h = Convert.ToDouble(Console.ReadLine());
        // Console.WriteLine($"Chi so BMI cua ban : {w/(h*h)}");
        // var BMI = w/(h*h);
        // if(BMI < 18.5){
        //     Console.WriteLine("Gay");
        // }else if (BMI >= 18.5 && BMI < 25){
        //     Console.WriteLine("Binh thuong");
        // }else if (BMI >=25 && BMI <30){
        //     Console.WriteLine("Tang Can");
        // }else {
        //     Console.WriteLine("Bao phi");
        //     if(BMI >= 30 && BMI <35){
        //         Console.WriteLine("Beo phi do 1");
        //     }else if(BMI >= 35 && BMI <40){
        //         Console.WriteLine("Bao phi do 2");
        //     }else{
        //         Console.WriteLine("Beo phi do 3");
        //     }
        // }

        // //Bai2: Viet chuong trinh giai phuong trinh bac 2
        // Console.WriteLine("Giai phuong trinh bac 2!");
        // Console.Write("Nhap he so a: ");
        // var a = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap he so b: ");
        // var b = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap he so c: ");
        // var c = Convert.ToDouble(Console.ReadLine());

        // if(a == 0){
        //     Console.WriteLine($"Phuong trinh bac nhat: {b}x + {c} = 0");
        //     if(b == 0){
        //         if(c==0){
        //             Console.WriteLine("Phuong trinh vo so nghiem!");
        //         }else{
        //             Console.WriteLine("Phuong trinh vo nghiem!");
        //         }
        //     }else{
        //         Console.WriteLine($"Phuong trinh co nghiem don duy nhat x = {-c/b}");
        //     }
        // }else{
        //     Console.WriteLine($"Phuong trinh bac 2: {a}x^2 + {b}x + c = 0");
        //     double delta = b*b - 4*a*c;
        //     if(delta < 0){
        //         Console.WriteLine("Phuong trinh vo nghiem!");
        //     }else if(delta == 0){
        //         Console.WriteLine($"Phuong trinh co nghiem kep x = {-b / (2 * a)}");
        //     }else {
        //         Console.Write("Phuong trinh co 2 nghiem phan biet: ");
        //         Console.Write($"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)} va x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
        //     }
        // }

        
        Console.ReadLine();
    }
}