
// 1 masala

//int kun;

//Console.WriteLine(" Hafta kunini kiriting: ");
//kun = int.Parse(Console.ReadLine());

//switch (kun)
//{
//    case 1:
//        Console.WriteLine(" Dushnaba "); 
//        break; 
//    case 2:
//        Console.WriteLine(" Seshanba ");  
//        break; 
//    case 3:
//        Console.WriteLine(" Chorshanba "); 
//        break; 
//    case 4:
//        Console.WriteLine(" Payshanba "); 
//        break; 
//    case 5:
//        Console.WriteLine(" Juma  "); 
//        break; 
//    case 6:
//        Console.WriteLine(" Shanba ");  
//        break; 
//    case 7:
//        Console.WriteLine(" Yakshanba "); 
//        break;
//    default:
//        Console.WriteLine(" Bunday hafta kuni mavjud emas "); break;   
//}


// 2 masala 

//int kun;

//Console.WriteLine(" Oy tartib raqamini kiriting: ");
//kun = int.Parse(Console.ReadLine());

//switch (kun)
//{
//    case 1:
//        Console.WriteLine(" Yanvar ");
//        break;
//    case 2:
//        Console.WriteLine(" Fevral ");
//        break;
//    case 3:
//        Console.WriteLine(" Mart ");
//        break;
//    case 4:
//        Console.WriteLine(" Aprel ");
//        break;
//    case 5:
//        Console.WriteLine(" May  ");
//        break;
//    case 6:
//        Console.WriteLine(" Iyun ");
//        break;
//    case 7:
//        Console.WriteLine(" Iyul ");
//        break;
//    case 8:
//        Console.WriteLine(" Avgust ");
//        break;
//    case 9:
//        Console.WriteLine(" Sentyabr ");
//        break;
//    case 10:
//        Console.WriteLine(" Oktyabr ");
//        break;
//    case 11:
//        Console.WriteLine(" Noyabr ");
//        break;
//    case 12:
//        Console.WriteLine(" Dekabr ");
//        break;
//    default:
//        Console.WriteLine(" Bunday Oy mavjud emas "); break;
//}

// 4 masala

//int kun;

//Console.WriteLine(" Oy tartib raqamini kiriting: ");
//kun = int.Parse(Console.ReadLine());

//switch (kun)
//{
//    case 1:
//        Console.WriteLine(" Yanvar Qish ");
//        break;
//    case 2:
//        Console.WriteLine(" Fevral  Qish ");
//        break;
//    case 3:
//        Console.WriteLine(" Mart Bahor ");
//        break;
//    case 4:
//        Console.WriteLine(" Aprel Bahor ");
//        break;
//    case 5:
//        Console.WriteLine(" May  Bahor");
//        break;
//    case 6:
//        Console.WriteLine(" Iyun Yoz ");
//        break;
//    case 7:
//        Console.WriteLine(" Iyul Yoz ");
//        break;
//    case 8:
//        Console.WriteLine(" Avgust  Yoz");
//        break;
//    case 9:
//        Console.WriteLine(" Sentyabr Kuz");
//        break;
//    case 10:
//        Console.WriteLine(" Oktyabr Kuz ");
//        break;
//    case 11:
//        Console.WriteLine(" Noyabr Kuz ");
//        break;
//    case 12:
//        Console.WriteLine(" Dekabr Qish ");
//        break;
//    default:
//        Console.WriteLine(" Bunday Oy mavjud emas "); break;
//}

// 5 masala

//int n, birlar, onlar;

//Console.WriteLine(" 1 dan katta 100 dan kichik son kiriting ");
//n = int.Parse(Console.ReadLine());

//birlar = n % 10;
//onlar = n / 10;

//switch (onlar)
//{
//    case 0: Console.Write("  "); break;
//    case 1: Console.Write(" O'n "); break;
//    case 2: Console.Write(" Yigirma "); break;
//    case 3: Console.Write(" O'ttiz "); break;
//    case 4: Console.Write(" Qirq "); break;
//    case 5: Console.Write(" Ellik "); break;
//    case 6: Console.Write(" Oltmish "); break;
//    case 7: Console.Write(" Yetmish "); break;
//    case 8: Console.Write(" Sakson "); break;
//    case 9: Console.Write(" To'qson "); break;
//    default: Console.Write(" Bunday son mavjud emas"); break;
//}

//switch (birlar)
//{
//    case 0: Console.Write(""); break;
//    case 1: Console.Write(" bir "); break;
//    case 2: Console.Write(" ikki "); break;
//    case 3: Console.Write(" uch "); break;
//    case 4: Console.Write(" to'rt "); break;
//    case 5: Console.Write(" besh "); break;
//    case 6: Console.Write(" olti "); break;
//    case 7: Console.Write(" yetti "); break;
//    case 8: Console.Write(" sakkiz "); break;
//    case 9: Console.Write(" to'qqiz "); break;
//    default: Console.Write(" Noto'g'ri son kiritdingiz,"); break;

//}



//int a;
//Console.WriteLine(" To'rt xonali son kiriting ");
//a = int.Parse(Console.ReadLine());

//int birlar = a % 10;
//int onlar = a / 10 % 10;
//int yuzlar = a / 100 % 10;
//int minglar = a / 1000;

//int res = birlar * onlar * yuzlar * minglar;

//Console.WriteLine(" Natija : " + res );

//6 masala 

//int kun, oy;

//Console.WriteLine(" Kunni kiriting: ");
//kun = int.Parse(Console.ReadLine());

//Console.WriteLine(" Oyni kiriting ");
//oy = int.Parse(Console.ReadLine());

//switch ( kun )
//{
//    case 1: Console.WriteLine(" Ikkinchi "); break;
//    case 2: Console.WriteLine(" Uchinchi "); break;
//    case 3: Console.WriteLine(" To'rtinchi "); break;
//    case 4: Console.WriteLine(" Beshinchi "); break;
//    case 5: Console.WriteLine(" Oltinchi "); break;
//    case 6: Console.WriteLine(" Yettinchi "); break;
//    case 7: Console.WriteLine(" Sakkizinchi "); break;
//    case 8: Console.WriteLine(" To'qqizinchi "); break;
//    case 9: Console.WriteLine(" O'ninchi "); break;
//    case 10: Console.WriteLine(" O'n birinchi "); break;
//    case 11: Console.WriteLine(" O'n ikkinchi "); break;
//    case 12: Console.WriteLine(" O'n uchinchi "); break;
//    case 13: Console.WriteLine(" O'n to'rtinchi "); break;
//    case 14: Console.WriteLine(" O'n beshinchi "); break;
//    case 15: Console.WriteLine(" O'n oltinchi "); break;
//    case 16: Console.WriteLine(" O'n yettinchi "); break;
//    case 17: Console.WriteLine(" O'n sakkizinchi "); break;
//    case 18: Console.WriteLine(" O'n to'qqizinchi "); break;
//    case 19: Console.WriteLine(" Yigirmanchi "); break;
//    case 20: Console.WriteLine(" Yigirma birinchi "); break;
//    case 21: Console.WriteLine(" Yigirma ikkinchi "); break;
//    case 22: Console.WriteLine(" Yigirma uchinchi "); break;
//    case 23: Console.WriteLine(" Yigirma to'rtinchi "); break;
//    case 24: Console.WriteLine(" Yigirma beshinchi "); break;
//    case 25: Console.WriteLine(" Yigirma oltinchi "); break;
//    case 26: Console.WriteLine(" Yigirma yettinchi "); break;
//    case 27: Console.WriteLine(" Yigirma sakkizinchi "); break;
//    case 28: Console.WriteLine(" Yigirma to'qqizinchi "); break;
//    case 29: Console.WriteLine(" O'ttizinchi  "); break;
//    case 30: Console.WriteLine(" O'ttiz birinchi "); break;
//    case 31: Console.WriteLine(" Birinchi "); break;
//    default: Console.WriteLine(" bunday oy kuni mavjud emas"); break;
//}

// if ( kun == 31 )
//{
//    oy++;
//}
// if ( oy == 13)
//{
//    oy = 1;
//}

//switch (oy )
//{
//    case 1:
//        Console.WriteLine(" Yanvar ");
//        break;
//    case 2:
//        Console.WriteLine(" Fevral ");
//        break;
//    case 3:
//        Console.WriteLine(" Mart ");
//        break;
//    case 4:
//        Console.WriteLine(" Aprel ");
//        break;
//    case 5:
//        Console.WriteLine(" May  ");
//        break;
//    case 6:
//        Console.WriteLine(" Iyun ");
//        break;
//    case 7:
//        Console.WriteLine(" Iyul ");
//        break;
//    case 8:
//        Console.WriteLine(" Avgust ");
//        break;
//    case 9:
//        Console.WriteLine(" Sentyabr ");
//        break;
//    case 10:
//        Console.WriteLine(" Oktyabr ");
//        break;
//    case 11:
//        Console.WriteLine(" Noyabr ");
//        break;
//    case 12:
//        Console.WriteLine(" Dekabr ");
//        break;
//    default:
//        Console.WriteLine(" Bunday Oy mavjud emas "); break;
//}

// 7 masala
//        int n, birlar, onlar, yuzlar , minglar;

//        Console.WriteLine(" 1 dan katta 10 000 dan kichik son kiriting ");
//        n = int.Parse(Console.ReadLine());
//////////////////// n = 9999
//        birlar = n % 10;
//        onlar = n / 10 % 10;
//        yuzlar = n / 100 % 10;
//        minglar = n / 1000% 10 ;
//        int million = n / 10000;







//switch (minglar)

//{ case 0: Console.Write("  "); break;
//    case 1: Console.Write(" bir ming "); break;
//    case 2: Console.Write(" Ikki yuz "); break;
//    case 3: Console.Write(" Uch ming "); break;
//    case 4: Console.Write(" To'rt ming "); break;
//    case 5: Console.Write(" Besh ming "); break;
//    case 6: Console.Write(" Olti ming "); break;
//    case 7: Console.Write(" Yetti ming "); break;
//    case 8: Console.Write(" Sakkiz ming "); break;
//    case 9: Console.Write(" To'qiz ming "); break;
//    case 10: Console.Write(" O'n ming ming "); break;
//    default: Console.Write(" Bunday son mavjud emas"); break; }

// switch (yuzlar)


//{  case 0: Console.Write("  "); break;
//    case 1: Console.Write(" Yuz "); break;
//    case 2: Console.Write(" Ikki yuz "); break;
//    case 3: Console.Write(" Uch yuz "); break;
//    case 4: Console.Write(" To'rt yuz "); break;
//    case 5: Console.Write(" Besh yuz "); break;
//    case 6: Console.Write(" Olti yuz "); break;
//    case 7: Console.Write(" Yetti yuz "); break;
//    case 8: Console.Write(" Sakkiz yuz "); break;
//    case 9: Console.Write(" To'qiz yuz "); break;
//    default: Console.Write(" Bunday son mavjud emas"); break; }

//switch (onlar)

//{ case 0: Console.Write("  "); break;
//    case 1: Console.Write(" O'n "); break;
//    case 2: Console.Write(" Yigirma "); break;
//    case 3: Console.Write(" O'ttiz "); break;
//    case 4: Console.Write(" Qirq "); break;
//    case 5: Console.Write(" Ellik "); break;
//    case 6: Console.Write(" Oltmish "); break;
//    case 7: Console.Write(" Yetmish "); break;
//    case 8: Console.Write(" Sakson "); break;
//    case 9: Console.Write(" To'qson "); break;
//    default: Console.Write(" Bunday son mavjud emas"); break; }


//switch (birlar)


//{
//    case 0: Console.Write(""); break;
//    case 1: Console.Write(" bir "); break;
//    case 2: Console.Write(" ikki "); break;
//    case 3: Console.Write(" uch "); break;
//    case 4: Console.Write(" to'rt "); break;
//    case 5: Console.Write(" besh "); break;
//    case 6: Console.Write(" olti "); break;
//    case 7: Console.Write(" yetti "); break;
//    case 8: Console.Write(" sakkiz "); break;
//    case 9: Console.Write(" to'qqiz "); break;
//    default: Console.Write(" Noto'g'ri son kiritdingiz,"); break;
//}

//// 8 masala

//int a, birlar, onlar;
//Console.Write(" - 100 dan - 1 gacha oraliqda son kiriting ");
//a = int.Parse(Console.ReadLine());

//birlar = a % 10;
//onlar = a / 10 % 10;

//Console.Write(" minus ");

//switch (onlar)

//{
//    case 0: Console.Write("  "); break;
//    case -1: Console.Write(" O'n "); break;
//    case -2: Console.Write(" Yigirma "); break;
//    case -3: Console.Write(" O'ttiz "); break;
//    case -4: Console.Write(" Qirq "); break;
//    case -5: Console.Write(" Ellik "); break;
//    case -6: Console.Write(" Oltmish "); break;
//    case -7: Console.Write(" Yetmish "); break;
//    case -8: Console.Write(" Sakson "); break;
//    case -9: Console.Write(" To'qson "); break;
//    default: Console.Write(" Bunday son mavjud emas"); break;
//}


//switch (birlar)


//{
//    case 0: Console.Write(""); break;
//    case -1: Console.Write(" bir "); break;
//    case -2: Console.Write(" ikki "); break;
//    case -3: Console.Write(" uch "); break;
//    case -4: Console.Write(" to'rt "); break;
//    case -5: Console.Write(" besh "); break;
//    case -6: Console.Write(" olti "); break;
//    case -7: Console.Write(" yetti "); break;
//    case -8: Console.Write(" sakkiz "); break;
//    case -9: Console.Write(" to'qqiz "); break;
//    default: Console.Write(" Noto'g'ri son kiritdingiz,"); break;
//}

// 9 masala

//int a, birlar, onlar , yuzlar;
//Console.Write(" - 100 dan - 1 gacha oraliqda son kiriting ");
//a = int.Parse(Console.ReadLine());

//birlar = a % 10;
//onlar = a / 10 % 10;
//yuzlar = a / 100; // 45
//if (a < 0)
//{

//    Console.Write(" minus ");
//}

//switch (yuzlar)

//{
//    case 0: Console.Write("  "); break;
//    case -1: Console.Write(" Bir yuz "); break;
//    case -2: Console.Write(" Ikki yuz "); break;
//    case -3: Console.Write(" Uch yuz "); break;
//    case -4: Console.Write(" To'rt yuz "); break;
//    case -5: Console.Write(" Besh yuz "); break;
//    case -6: Console.Write(" Olti yuz "); break;
//    case -7: Console.Write(" Yetti yuz "); break;
//    case -8: Console.Write(" Sakkiz yuz "); break;
//    case -9: Console.Write(" To'qqiz yuz "); break;
//    default:
//        Console.Write(" Bunday son mavjud emas"); break;
//}

//        switch (onlar)

//{
//    case 0: Console.Write("  "); break;
//    case -1: Console.Write(" O'n "); break;
//    case -2: Console.Write(" Yigirma "); break;
//    case -3: Console.Write(" O'ttiz "); break;
//    case -4: Console.Write(" Qirq "); break;
//    case -5: Console.Write(" Ellik "); break;
//    case -6: Console.Write(" Oltmish "); break;
//    case -7: Console.Write(" Yetmish "); break;
//    case -8: Console.Write(" Sakson "); break;
//    case -9: Console.Write(" To'qson "); break;
//    default: Console.Write(" Bunday son mavjud emas"); break;
//}


//switch (birlar)


//{
//    case 0: Console.Write(""); break;
//    case -1: Console.Write(" bir "); break;
//    case -2: Console.Write(" ikki "); break;
//    case -3: Console.Write(" uch "); break;
//    case -4: Console.Write(" to'rt "); break;
//    case -5: Console.Write(" besh "); break;
//    case -6: Console.Write(" olti "); break;
//    case -7: Console.Write(" yetti "); break;
//    case -8: Console.Write(" sakkiz "); break;
//    case -9: Console.Write(" to'qqiz "); break;
//    default: Console.Write(" Noto'g'ri son kiritdingiz,"); break;
//}


// 10 masala 


//int n;
//Console.WriteLine(" Bahoyingizni kiriting ");
//n = int.Parse(Console.ReadLine());

//switch (n)
//{
//    case 1: Console.WriteLine(" Yomon "); break;
//    case 2: Console.WriteLine(" Qoniqarsiz "); break;
//    case 3: Console.WriteLine(" Qoniqarli "); break;
//    case 4: Console.WriteLine(" Yaxshi "); break;
//    case 5: Console.WriteLine(" A'lo "); break;
//    default: Console.WriteLine(" Error "); break;


//}

// 12 masala

//long n, a;
//Console.WriteLine(" Son kiriting ");
//a = long.Parse(Console.ReadLine());
//Console.WriteLine(" Ammallardan birini kiriting: + , - , * , / ");
//char sum = char.Parse(Console.ReadLine());
//Console.WriteLine(" Son kiriting ");
//n = long.Parse(Console.ReadLine());


//switch (sum)
//{
//    case '+': Console.WriteLine(" Natija: " + (a + n)); break;
//    case '-': Console.WriteLine(" Natija: " + (a - n)); break;
//    case '*': Console.WriteLine(" Natija: " + (a * n)); break;
//    case '/': Console.WriteLine(" Natija: " + (a / n)); break;
//    default: Console.WriteLine(" Error "); break;
//}

// 13 masala

//long a , b ;

//Console.WriteLine(" Valyuta turini tanlang");
//Console.WriteLine(" 1. Dollar ");
//Console.WriteLine(" 2. Euro");
//Console.WriteLine(" 3. Rubl");
//Console.WriteLine(" 4. Funt sterling");
//Console.WriteLine(" 5. Yein ");

//a = long.Parse(Console.ReadLine());

//Console.WriteLine(" Necha pul ayirboshlamoqchisiz so'mda kiriting");
//b = long.Parse(Console.ReadLine());

//switch( a)
//{
//    case 1: Console.WriteLine(  " Pulingiz valyutada: " + ( b / 12531.78)); break; 
//    case 2: Console.WriteLine(  " Pulingiz valyutada: " + ( b / 14538.12)); break; 
//    case 3: Console.WriteLine(  " Pulingiz valyutada: " + ( b / 159.82)); break; 
//    case 4: Console.WriteLine(  " Pulingiz valyutada: " + ( b / 17059.51)); break; 
//    case 5: Console.WriteLine(  " Pulingiz valyutada: " + ( b  / 86.05)); break;
//    default: Console.WriteLine(" Error"); break;

//}

// 16 masala


//s
































































































