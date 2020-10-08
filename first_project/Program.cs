

using System;
namespace first_project
{
    class Program
    {
        private static void PascalCase(string str)
        {
            char ch0 = str[0], ch;
            string begin_str, total_str = null;
            ch0 = char.ToUpper(ch0);
            str = str.Remove(0, 1);
            str = ch0 + str;
       
            for ( int i = 0; i < str.Length; i++ )
            {

                if (str[i] == '-')
                {

                    str = str.Remove(i, 1);
                    ch = str[i];
                    ch = char.ToUpper(ch);
                    begin_str = str.Substring(0, i);
                    str = str.Substring(i + 1);
                    i = 0;
                    total_str = total_str + begin_str + ch;

                }//kebab-case

                else if (str[i] == '_')
                {

                    str = str.Remove(i, 1);
                    ch = str[i];
                    ch = char.ToUpper(ch);
                    begin_str = str.Substring(0, i);
                    str = str.Substring(i + 1);
                    i = 0;
                    total_str = total_str + begin_str + ch;
                    
                }//snake-case

            }

            total_str += str;
            Console.WriteLine($"{total_str} - converted to PascalCase");

        }

        private static void CamelCase(string str)
         {

            char ch0 = str[0], ch;
            string begin_str, total_str = null;

            ch0 = char.ToLower(ch0);
            str = str.Remove(0, 1);
            int j = 0;

            while ((Convert.ToInt16(str[j]) >= 65 && Convert.ToInt16(str[j]) <= 90))
            {

                if ((Convert.ToInt16(str[j + 1]) >= 65 && Convert.ToInt16(str[j + 1]) <= 90))
                {
                    ch = str[j];
                    begin_str = str.Substring(0, j);
                    str = str.Remove(j, 1);
                    //str = str.Substring(j + 1);
                    ch = char.ToLower(ch);
                    total_str = total_str + begin_str + ch;
                    
                    
                }

                else
                {
                    ch = str[j];
                    begin_str = str.Substring(0, j);
                    str = str.Remove(j, 1);
                   // str = str.Substring(j + 1);
                    ch = char.ToUpper(ch);
                    total_str = total_str + begin_str + ch;
                    
                }

            }

            begin_str = null;
            string check_str = null;

            for (int i = 0; i < str.Length; i++)
            {


                if (str[i] == '-')
                {
                    str = str.Remove(i, 1);
                    ch = str[i];
                    ch = char.ToUpper(ch);
                    begin_str = str.Substring(0, i);
                    str = str.Substring(i + 1);
                    i = 0;
                    total_str = total_str + begin_str + ch;
                }//kebab-case

                else if (str[i] == '_')
                {

                    str = str.Remove(i, 1);
                    ch = str[i];
                    ch = char.ToUpper(ch);
                    begin_str = str.Substring(0, i);
                    str = str.Substring(i + 1);
                    i = 0;
                    total_str = total_str + begin_str + ch;

                }//snake-case

            }

            total_str = ch0 + total_str + str;

            for (int i = 0; i < total_str.Length; i++)
            {

                if (Convert.ToInt16(total_str[i]) >= 65 && Convert.ToInt16(total_str[i]) <= 90)
                {

                    while (Convert.ToInt16(total_str[i + 1]) >= 65 && Convert.ToInt16(total_str[i + 1]) <= 90)
                    {

                        if (begin_str == null)
                        {

                            begin_str = total_str.Substring(0, i+1);
                            total_str = total_str.Remove(0, i+1);
                            i = 0;

                        }

                        else
                        {

                            ch = char.ToLower(total_str[i]);
                            begin_str += ch;
                            total_str = total_str.Remove(0, 1);
                            i = 0;

                        }
                        
                    }

                    check_str += begin_str;
                    begin_str = null;

                }

            }

            check_str += total_str;

            if (begin_str == null)
            {

                Console.WriteLine($"{check_str} - converted to camelCase");

            }

            else Console.WriteLine($"{total_str} - converted to camelCase");
        
        }

        private static void KebabCase(string str)
        {
            char ch0 = str[0], ch;
            string total_str = null;

            int i = 0;
            int j = 1;//Для запоминания индекса элемента '-'

            ch0 = char.ToLower(ch0);
            total_str += ch0;
            str = str.Remove(0, 1);


            while (str.Length > 2)
            {

                if (Convert.ToInt16(str[i]) >= 65 && Convert.ToInt16(str[i]) <= 90)
                {

                    while (Convert.ToInt16(str[i]) >= 65 && Convert.ToInt16(str[i]) <= 90)
                    {

                        if (str.Length < 2)
                        {

                            break;

                        }

                        if (Convert.ToInt16(str[i + 1]) > 90)
                        {

                            if (total_str != null && total_str[j - 1] == '-')
                            {

                                ch = char.ToLower(str[i]);
                                total_str = total_str + ch;

                                str = str.Remove(i, 1);
                                i = 0;
                                break;

                            }

                            else
                            {

                                ch = char.ToLower(str[i]);
                                total_str = total_str + '-' + ch;

                                str = str.Remove(i, 1);
                                i = 0;
                                break;

                            }

                        }

                        else
                        {

                            ch = char.ToLower(str[i]);
                            str = str.Remove(i, 1);
                            total_str = total_str + ch;
                            j = 1;

                        }
                    }
                }

                else if (str[i] == '_')
                {

                    str = str.Replace('_', '-');
                    break;

                }

                else
                {

                    if (Convert.ToInt16(str[i + 1]) >= 65 && Convert.ToInt16(str[i + 1]) <= 90)
                    {

                        ch = str[i];
                        str = str.Remove(i, 1);
                        total_str = total_str + ch + '-';
                        j = total_str.Length;

                    }

                    else
                    {

                        ch = str[i];
                        str = str.Remove(i, 1);
                        total_str = total_str + ch;

                    }
                }
            }

                str = str.ToLower();
                Console.WriteLine($"{total_str + str} - converted to kebab-case");
          
    }

        private static void SnakeCase(string str)
        {

            char ch0 = str[0], ch;
            string total_str = null;

            int i = 0;
            int j = 1;//Для запоминания индекса элемента '-'

            ch0 = char.ToLower(ch0);
            total_str += ch0;
            str = str.Remove(0, 1);


            while (str.Length > 2)
            {

                if (Convert.ToInt16(str[i]) >= 65 && Convert.ToInt16(str[i]) <= 90)
                {

                    while (Convert.ToInt16(str[i]) >= 65 && Convert.ToInt16(str[i]) <= 90)
                    {

                        if (str.Length < 2)
                        {

                            break;

                        }

                        if (Convert.ToInt16(str[i + 1]) > 90)
                        {

                            if (total_str != null && total_str[j - 1] == '_')
                            {

                                ch = char.ToLower(str[i]);
                                total_str = total_str + ch;

                                str = str.Remove(i, 1);
                                i = 0;
                                break;

                            }

                            else
                            {

                                ch = char.ToLower(str[i]);
                                total_str = total_str + '_' + ch;

                                str = str.Remove(i, 1);
                                i = 0;
                                break;

                            }
                        }

                        else
                        {

                            ch = char.ToLower(str[i]);
                            str = str.Remove(i, 1);
                            total_str = total_str + ch;
                            j = 1;

                        }
                    }
                }

                else if (str[i] == '-')
                {

                    str = str.Replace('-', '_');
                    break;

                }

                else
                {

                    if (Convert.ToInt16(str[i + 1]) >= 65 && Convert.ToInt16(str[i + 1]) <= 90)
                    {

                        ch = str[i];
                        str = str.Remove(i, 1);
                        total_str = total_str + ch + '_';
                        j = total_str.Length;

                    }

                    else
                    {

                        ch = str[i];
                        str = str.Remove(i, 1);
                        total_str = total_str + ch;

                    }
                }
            }

            str = str.ToLower();
            Console.WriteLine($"{total_str + str} - converted to snake_case");

        }

        private static void FunCheck(string str)
        {
            int id = 0; //1-unknow 2-PascalCase 3-camelCase 4- xxx-case 5- snake_case
            int dash = 0;//Для подсчёта тире
            int under_score = 0;//Для подсчета нижних подчеркиваний
            Console.WriteLine("Hello");

//------------------------

          if (Convert.ToInt16(str[0]) >=65 && Convert.ToInt16(str[0])<=90)//Check PascalCase or unknow
            {
                for (int i = 1; i < str.Length; i++)
                {

                    if ((str[i] == '_') || (str[i] == '-'))
                    {
                        Console.WriteLine($"{str}- unknow type");
                        break;
                    }

                    if (Convert.ToInt16(str[i]) >= 65 && Convert.ToInt16(str[i]) <= 90 && str.Length > 2)
                    {

                        id = 2;

                    }

                }

                if (id == 2)
                {
                    Console.WriteLine($"{str} - PascalCase type");
                    Console.WriteLine("1- camelCase");
                    Console.WriteLine("2- kebab-case");
                    Console.WriteLine("3- snake_case");
                    int type_id = Convert.ToInt32(Console.ReadLine());

                    if (type_id == 1)
                    {

                        CamelCase(str);

                    }

                    else if (type_id == 2)
                    {

                        KebabCase(str);

                    }

                    else if (type_id == 3)
                    {

                        SnakeCase(str);

                    }

                    else
                    {

                        Console.WriteLine("Введите еще раз: ");
                        type_id = Convert.ToInt32(Console.ReadLine());

                    }

                }//PascalCase
            }
        
//------------------------

          else
            {
                for(int i=1; i<str.Length; i++)
                {
                    if((Convert.ToInt16(str[i])==45 || Convert.ToInt16(str[i])>90) && str.Length>2)//Check kebab-case or snake-kase
                    {
                        if (str[i]== '-' )
                        {
                            if (str[i - 1] != '-' || str[i - 1] != '_')
                            {
                                if (i != str.Length)
                                {
                                    id = 4;
                                    dash += 1;
                                }

                                else id = 1;
                             
                            }
                            else id = 1;
                              
                            
                        }
                        else if (str[i] == '_')
                        {
                            if ((str[i - 1] != '-' || str[i - 1] != '_') && (i != str.Length))
                            {
                                id = 5;
                                under_score += 1;
                            }
                            else
                            
                                id = 1;
                            
                            
                        }
                    }
                    else if (Convert.ToInt16(str[i]) >= 65 && Convert.ToInt16(str[i]) <= 90)
                    {
                        id = 3;
                    }
                }
                if (id == 4 && under_score == 0)
                {
                    Console.WriteLine($"{str} - kebab-case");
                    Console.WriteLine("1- PascalCase");
                    Console.WriteLine("2- camelCase");
                    Console.WriteLine("3- snake_case");

                    int type_id = Convert.ToInt32(Console.ReadLine());

                    if (type_id == 1)
                    {

                        PascalCase(str);

                    }

                    else if (type_id == 2)
                    {
                        CamelCase(str);
                    }

                    else if (type_id == 3)
                    {

                        SnakeCase(str);

                    }

                    else
                    {
                        Console.WriteLine("Введите еще раз: ");
                        type_id = Convert.ToInt32(Console.ReadLine());
                    }



                }//kebab-case
                else if (id == 5 && dash == 0)
                {
                    Console.WriteLine($"{str} - snake_case");
                    Console.WriteLine("1- PascalCase");
                    Console.WriteLine("2- camelCase");
                    Console.WriteLine("3- kebab-case");

                    int type_id = Convert.ToInt32(Console.ReadLine());

                    if (type_id == 1)
                    {

                        PascalCase(str);

                    }

                    else if (type_id == 2)
                    {

                        CamelCase(str);

                    }

                    else if (type_id == 3)
                    {
                        KebabCase(str);
                    }

                }//snake_case
                else if (id ==3)
                {
                    Console.WriteLine($"{str}- camelCase type");
                    Console.WriteLine("1- PascalCase");
                    Console.WriteLine("2- kebab-case");
                    Console.WriteLine("3- snake_case");
                    int type_id = Convert.ToInt32(Console.ReadLine());
                    if (type_id == 1)
                    {
                    
                        PascalCase(str);

                    }
                    else if (type_id == 2)
                    {
                        KebabCase(str);
                    }

                    else if (type_id == 3)
                    {

                        SnakeCase(str);
                    
                    }
                    else
                    {
                        Console.WriteLine("Введите еще раз: ");
                        type_id = Convert.ToInt32(Console.ReadLine());
                    }
                }//camelCase
                else Console.WriteLine($"{str} - unknow type");
            }

//-----------------------
        }

        static void Main(string[] args)
        {

            Console.Write("Введите строку ");
            string check_str = Console.ReadLine();
            FunCheck(check_str);
            Console.ReadKey();


        }
    }
}
