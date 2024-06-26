namespace Lesson04;

class SwitchCase
{
    static void Main(string[] args)
    {
        // Console.Write("Enter month: ");
        // int month = Convert.ToInt32(Console.ReadLine());
        // #region SwitchCase not clean code 
        // switch(month)
        // {
        //     case 1: 
        //         Console.WriteLine("31 days");
        //         break;
        //     case 2:
        //         Console.WriteLine("28 or 29 days");
        //         break;
        //     case 3:
        //         Console.WriteLine("30 days");
        //         break;
        //     case 4: 
        //         Console.WriteLine("30 days");
        //         break;
        //     case 5:
        //         Console.WriteLine("31 days");
        //         break;
        //     case 6:
        //         Console.WriteLine("30 days");
        //         break;
        //     case 7: 
        //         Console.WriteLine("31 days");
        //         break;
        //     case 8:
        //         Console.WriteLine("31 days");
        //         break;
        //     case 9:
        //         Console.WriteLine("30 days");
        //         break;
        //     case 10: 
        //         Console.WriteLine("31 days");
        //         break;
        //     case 11:
        //         Console.WriteLine("30 days");
        //         break;
        //     case 12:
        //         Console.WriteLine("31 days");
        //         break;
        //     default:
        //         Console.WriteLine("Invalid month! Pleas try again!");
        //         break;
        // }
        //#endregion

        //Co 2 loai loi
        //1. systax error
        //2. logic error

        // #region Bai tap 1
        // Console.Write("Nhap so : ");
        // int numb = Convert.ToInt32(Console.ReadLine());

        // switch(numb){
        //     case 1:
        //         Console.WriteLine("Thu hai");
        //         break;
        //     case 2:
        //         Console.WriteLine("Thu ba");
        //         break;
        //     case 3:
        //         Console.WriteLine("Thu tu");
        //         break;
        //     case 4:
        //         Console.WriteLine("Thu nam");
        //         break;
        //     case 5:
        //         Console.WriteLine("Thu sau");
        //         break;
        //     case 6:
        //         Console.WriteLine("Thu bay");
        //         break;
        //     case 7:
        //         Console.WriteLine("Chu nhat");
        //         break;
        //     default:
        //         Console.WriteLine("So khong hop le! Vui long nhap so tu 1->7!");
        //         break;
        // }
        //#endregion

        //Naming Convention : hovaten tonghaiso
        /*
        F1: PascalCase => HoVaTen TongHaiSo => namespace, class, method
        F2: camelCase => hoVaTen tongHaiSo => varible
        F3: snake_case => ho_va_ten tong_hai_so
        */

        // Console.Write("Nhap he so a: ");
        // var a = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap he so b: ");
        // var b = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Nhap he so c: ");
        // var c = Convert.ToDouble(Console.ReadLine());

        // bool check_a = a==0?true:false;
        // bool check_b = b==0?true:false;
        // bool check_c = c==0?true:false;

        // switch(check_a)
        // {
        //     case true:
        //         Console.WriteLine($"Phuong trinh bac nhat: {b}x + {c} = 0");
        //         switch(check_b)
        //         {
        //             case true:
        //                 switch(check_c){
        //                     case true:
        //                         Console.WriteLine("Phuong trinh vo so nghiem!");
        //                         break;
        //                     case false:
        //                         Console.WriteLine("Phuong trinh vo nghiem!");
        //                         break;
        //                 }
        //                 break;
        //             case false:
        //                 Console.WriteLine($"Phuong trinh co nghiem don duy nhat x = {-c/b}");
        //                 break;
        //         }
        //         break;
        //     case false:
        //         Console.WriteLine($"Phuong trinh bac 2: {a}x^2 + {b}x + c = 0");
        //         double delta = b*b - 4*a*c;
        //         switch(delta<0?true:false){
        //             case true:
        //                 Console.WriteLine("Phuong trinh vo nghiem!");
        //                 break;
        //             case false:
        //                 switch(delta==0?true:false){
        //                     case true:
        //                         Console.WriteLine($"Phuong trinh co nghiem kep x = {-b / (2 * a)}");
        //                         break;
        //                     case false:
        //                         Console.Write("Phuong trinh co 2 nghiem phan biet: ");
        //                         Console.Write($"x1 = {(-b + Math.Sqrt(delta)) / (2 * a)} va x2 = {(-b - Math.Sqrt(delta)) / (2 * a)}");
        //                         break;
        //                 }
        //                 break;
        //         }
        //         break;
        // }

        /*#region Bai 3
        Console.Write("Nhap diem trung binh nam hoc: ");
        var dtb = Convert.ToDouble(Console.ReadLine());
        if(dtb<0 || dtb > 10){
            Console.WriteLine("Invalid");
        }else
        {
            if(dtb>=9 && dtb<=10){
                Console.WriteLine("Xuat sac");
            }else if(dtb>=8 && dtb<9){
                Console.WriteLine("Gioi");
            }else if(dtb>=7 && dtb<8){
                Console.WriteLine("Kha");
            }else if(dtb>=5 && dtb<7){
                Console.WriteLine("Trung binh");
            }else{
                Console.WriteLine("Yeu");
            }
        }
        #endregion*/

        Console.Write("Nhap diem trung binh nam hoc: ");
        var dtb = Convert.ToDouble(Console.ReadLine());
        switch (dtb < 0 || dtb > 10)
        {
            case false:
                switch (dtb >= 9 && dtb <= 10)
                {
                    case true:
                        Console.WriteLine("Xuat sac");
                        break;
                    case false:
                        switch (dtb >= 8 && dtb < 9)
                        {
                            case true:
                                Console.WriteLine("Gioi");
                                break;
                            case false:
                                switch (dtb >= 7 && dtb < 8)
                                {
                                    case true:
                                        Console.WriteLine("Kha");
                                        break;
                                    case false:
                                        switch (dtb >= 5 && dtb < 7)
                                        {
                                            case true:
                                                Console.WriteLine("Trung binh");
                                                break;
                                            case false:
                                                switch (dtb >= 0 && dtb < 5)
                                                {
                                                    case true:
                                                        Console.WriteLine("Trung binh");
                                                        break;
                                                    case false:
                                                        break;
                                                }
                                                break;
                                        }
                                        break;
                                }
                                break;
                        }
                        break;
                }
                break;
            case true:
                Console.WriteLine("Invalid value!");
                break;
        }


        Console.ReadLine();
    }
}