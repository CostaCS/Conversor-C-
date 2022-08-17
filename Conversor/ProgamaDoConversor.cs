using System;
namespace conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int  opcao, opcaomed, opcaomoeda, opcaopeso, opcaomedmet, opcaomedvol, opcaomoedadolar, opcaomoedaeuro;
            Console.ForegroundColor = ConsoleColor.Blue;
            
            menu:

            Console.WriteLine(" _______________________________________________________________________________");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|/////////////////////////////////CONVERSOR/////////////////////////////////////|");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|Por favor escolha uma opção:                                                   |");
            Console.WriteLine("|                                                                               |");
            Console.WriteLine("|-----1-CONVERSOR DE MEDIDAS----------------------------------------------------|");
            Console.WriteLine("|-----2-CONVERSOR DE MOEDAS-----------------------------------------------------|");
            Console.WriteLine("|-----3-CONVERSOR DE PESO-------------------------------------------------------|");
            Console.WriteLine("|-----4-SAIR--------------------------------------------------------------------|");
            Console.WriteLine("|_______________________________________________________________________________|");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
                {   
                    case 1://INICIO DO CONVERSOR DE MEDIDAS
                        menumed:

                            Console.WriteLine(" _______________________________________________________________________________");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|/////////////////////////////CONVERSOR DE MEDIDAS//////////////////////////////|");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|-----1-CONVERSOR DE MEDIDAS MÉTRICAS-------------------------------------------|");
                            Console.WriteLine("|-----2-CONVERSOR DE MEDIDAS VOLUMÉTRICAS---------------------------------------|");
                            Console.WriteLine("|-----3-VOLTAR AO MENU PRINCIPAL------------------------------------------------|");
                            Console.WriteLine("|_______________________________________________________________________________|");
                            opcaomed = int.Parse(Console.ReadLine());

                                switch(opcaomed)
                                    {
                                        
                                        case 1:
                                            menumet:
                                                Console.WriteLine(" _______________________________________________________________________________");
                                                Console.WriteLine("|                                                                               |");
                                                Console.WriteLine("|////////////////////////CONVERSOR DE MEDIDAS MÉTRICAS//////////////////////////|");
                                                Console.WriteLine("|                                                                               |");
                                                Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                                                Console.WriteLine("|                                                                               |");
                                                Console.WriteLine("|-----1-METRO PARA CENTÍMETRO---------------------------------------------------|");
                                                Console.WriteLine("|-----2-CENTÍMETRO PARA METRO---------------------------------------------------|");
                                                Console.WriteLine("|-----3-VOLTAR AO MENU ANTERIOR-------------------------------------------------|");
                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                opcaomedmet = int.Parse(Console.ReadLine());

                                                switch(opcaomedmet)
                                                    {
                                                        case 1:
                                                            menumet1:
                                                            Double valor1, opcaomedmet1;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|/////////////////////CONVERSOR DE METRO PARA CENTÍMETRO////////////////////////|");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--DIGITE O VALOR QUE DESEJA CONVERTER:                                         |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                valor1 = double.Parse(Console.ReadLine());
                                                                valor1 = valor1 * 100;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--O valor da conversão é: {0} Cm.                                               ", valor1);
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                Console.WriteLine("|--2-VOLTAR AO MENU DE MEDIDAS MÉTRICAS-----------------------------------------|");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                opcaomedmet1 = double.Parse(Console.ReadLine());
                                                                
                                                                if(opcaomedmet1 == 1)
                                                                    {
                                                                        goto menumet1;
                                                                    }
                                                                else if(opcaomedmet1 == 2)
                                                                    {
                                                                        goto menumet;
                                                                    }
                                                                else
                                                                    {
                                                                         Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                         goto menumet1;
                                                                    }
                                                        break;

                                                        case 2:
                                                                 menumet2:
                                                            Double valor2, opcaomedmet2;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|/////////////////////CONVERSOR DE CENTÍMETRO PARA METRO////////////////////////|");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--DIGITE O VALOR QUE DESEJA CONVERTER:                                         |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                valor2 = double.Parse(Console.ReadLine());
                                                                valor2 = valor2 / 100;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--O valor da conversão é: {0} M.                                                ", valor2);
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                Console.WriteLine("|--2-VOLTAR AO MENU DE MEDIDAS MÉTRICAS-----------------------------------------|");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                opcaomedmet2 = double.Parse(Console.ReadLine());
                                                                
                                                                if(opcaomedmet2 == 1)
                                                                    {
                                                                        goto menumet2;
                                                                    }
                                                                else if(opcaomedmet2 == 2)
                                                                    {
                                                                        goto menumet;
                                                                    }
                                                                else
                                                                    {
                                                                         Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                         goto menumet2;
                                                                    }
                                                        break;

                                                        case 3:
                                                            goto menumed; 
                                                        break;

                                                        default:
                                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                            goto menumet;
                                                        break;
                                                    }
                                        break;

                                        case 2:
                                                 menuvol:
                                                Console.WriteLine(" _______________________________________________________________________________");
                                                Console.WriteLine("|                                                                               |");
                                                Console.WriteLine("|//////////////////////CONVERSOR DE MEDIDAS VOLUMÉTRICAS////////////////////////|");
                                                Console.WriteLine("|                                                                               |");
                                                Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                                                Console.WriteLine("|                                                                               |");
                                                Console.WriteLine("|-----1-LITRO PARA MILILITRO----------------------------------------------------|");
                                                Console.WriteLine("|-----2-MILILITRO PARA LITRO----------------------------------------------------|");
                                                Console.WriteLine("|-----3-VOLTAR AO MENU ANTERIOR-------------------------------------------------|");
                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                opcaomedvol = int.Parse(Console.ReadLine());

                                                switch(opcaomedvol)
                                                    {
                                                        case 1:
                                                            menuvol1:
                                                            Double valor1, opcaomedvol1;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|/////////////////////CONVERSOR DE LITRO PARA MILILITRO/////////////////////////|");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--DIGITE O VALOR QUE DESEJA CONVERTER:                                         |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                valor1 = double.Parse(Console.ReadLine());
                                                                valor1 = valor1 * 1000;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--O valor da conversão é: {0} Ml.                                               ", valor1);
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                Console.WriteLine("|--2-VOLTAR AO MENU DE MEDIDAS VOLUMÉTRICAS-------------------------------------|");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                opcaomedvol1 = double.Parse(Console.ReadLine());
                                                                
                                                                if(opcaomedvol1 == 1)
                                                                    {
                                                                        goto menuvol1;
                                                                    }
                                                                else if(opcaomedvol1 == 2)
                                                                    {
                                                                        goto menuvol;
                                                                    }
                                                                else
                                                                    {
                                                                         Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                         goto menuvol1;
                                                                    }
                                                        break;

                                                        case 2:
                                                                 menuvol2:
                                                            Double valor2, opcaomedvol2;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|/////////////////////CONVERSOR DE MILILITRO PARA LITRO/////////////////////////|");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--DIGITE O VALOR QUE DESEJA CONVERTER:                                         |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                valor2 = double.Parse(Console.ReadLine());
                                                                valor2 = valor2 / 1000;
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--O valor da conversão é: {0} L.                                                ", valor2);
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                Console.WriteLine("|--2-VOLTAR AO MENU DE MEDIDAS MÉTRICAS-----------------------------------------|");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                opcaomedvol2 = double.Parse(Console.ReadLine());
                                                                
                                                                if(opcaomedvol2 == 1)
                                                                    {
                                                                        goto menuvol2;
                                                                    }
                                                                else if(opcaomedvol2 == 2)
                                                                    {
                                                                        goto menuvol;
                                                                    }
                                                                else
                                                                    {
                                                                         Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                         goto menuvol2;
                                                                    }
                                                        break;

                                                        case 3:
                                                            goto menumed; 
                                                        break;

                                                        default:
                                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                            goto menumet;
                                                        break;
                                                    }
                                        break;

                                        case 3:
                                             goto menu;
                                        break;

                                        default:
                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                             goto menumed;
                                        break;
                                    }

                    break;//FIM DO CONVERSOR DE MEDIDAS
                            
                    case 2://INICIO DO CONVERSOR DE MOEDAS
                            menumoeda:
                            Console.WriteLine(" _______________________________________________________________________________");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|/////////////////////////////CONVERSOR DE MOEDAS///////////////////////////////|");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|-----1-CONVERSOR DE DÓLAR------------------------------------------------------|");
                            Console.WriteLine("|-----2-CONVERSOR DE EURO-------------------------------------------------------|");
                            Console.WriteLine("|-----3-VOLTAR AO MENU PRINCIPAL------------------------------------------------|");
                            Console.WriteLine("|_______________________________________________________________________________|");
                            opcaomoeda = int.Parse(Console.ReadLine());

                                    switch (opcaomoeda)
                                    {
                                                    case 1://INCIO DO CONVERSOR DE DÓLAR
                                                            menudolar:
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|//////////////////////////////CONVERSOR DE DÓLAR///////////////////////////////|");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|-----1-DÓLAR PARA REAL---------------------------------------------------------|");
                                                                Console.WriteLine("|-----2-REAL PARA DÓLAR---------------------------------------------------------|");
                                                                Console.WriteLine("|-----3-VOLTAR AO MENU ANTERIOR-------------------------------------------------|");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                opcaomoedadolar = int.Parse(Console.ReadLine());

                                                                    switch(opcaomoedadolar)
                                                                    {
                                                                                case 1://INICIO DO CONVERSOR DE DOLAR PARA REAL
                                                                                    menudolar1:
                                                                                    Double valor1, valordolar, opcaomoedadolar1, opcaodolar;
                                                                                        Console.WriteLine(" _______________________________________________________________________________");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|/////////////////////////CONVERSOR DE DÓLAR PARA REAL//////////////////////////|");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|------------------Atualmente USD $1 dólar equivale a BRL R$4,83.---------------|");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--Deseja alterar o valor da cotação para a conversão ?                         |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--1-SIM (ALTERAR VALOR DA COTAÇÃO)---------------------------------------------|");
                                                                                        Console.WriteLine("|--2-NÃO (UTILIZAR O VALOR ATUAL)-----------------------------------------------|");
                                                                                        Console.WriteLine("|_______________________________________________________________________________|");
                                                                                        opcaodolar= double.Parse(Console.ReadLine());
                                                                                                    if(opcaodolar==1)
                                                                                                        {
                                                                                                            Console.WriteLine(" _______________________________________________________________________________");
                                                                                                            Console.WriteLine("|                                                                               |");
                                                                                                            Console.WriteLine("|--INSIRA O VALOR DA COTAÇÃO DO DÓLAR:                                          |");                                  
                                                                                                            Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                            valordolar= double.Parse(Console.ReadLine());
                                                                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE DÓLAR PARA REAL///////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM DÓLARES QUE DESEJA CONVERTER:                              |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor1 = double.Parse(Console.ReadLine());

                                                                                                                valor1 = valor1 * valordolar ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: R${0}.                                               ", valor1);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU DÓLAR-------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedadolar1 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedadolar1 == 1)
                                                                                                                        {
                                                                                                                            goto menudolar1;
                                                                                                                        }
                                                                                                                    else if(opcaomoedadolar1 == 2)
                                                                                                                        {
                                                                                                                            goto menudolar;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menudolar1;
                                                                                                                        }
                                                                                                        }
                                                                                                    else if(opcaodolar==2)
                                                                                                        {
                                                                                                            valordolar = 4.83;
                                                                                                            Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE DÓLAR PARA REAL///////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM DÓLARES QUE DESEJA CONVERTER:                              |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor1 = double.Parse(Console.ReadLine());

                                                                                                                valor1 = valor1 * valordolar ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: R${0}.                                               ", valor1);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU DÓLAR-------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedadolar1 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedadolar1 == 1)
                                                                                                                        {
                                                                                                                            goto menudolar1;
                                                                                                                        }
                                                                                                                    else if(opcaomoedadolar1 == 2)
                                                                                                                        {
                                                                                                                            goto menudolar;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menudolar1;
                                                                                                                        }
                                                                                                        }
                                                                                                    else
                                                                                                        {
                                                                                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                             goto menudolar1;
                                                                                                        }
                                                              
                                                                                break;//FIM DO COVERSOR DE DÓLAR PARA REAL
                                                   

                                                                                case 2://INICIO DO CONVERSOR DE REAL PARA DÓLAR
                                                                                             menudolar2:
                                                                                        Double valor2, valordolarreal, opcaomoedadolar2, opcaodolarreal;
                                                                                        Console.WriteLine(" _______________________________________________________________________________");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|/////////////////////////CONVERSOR DE REAL PARA DÓLAR//////////////////////////|");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--------------------Atualmente BRL R$ 1 equivale a USD $0,21.------------------|");
                                                                                        Console.WriteLine("|                                (USD$ 1 = R$4,83)                              |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--Deseja alterar o valor da cotação para a conversão ?                         |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--1-SIM (ALTERAR VALOR DA COTAÇÃO)---------------------------------------------|");
                                                                                        Console.WriteLine("|--2-NÃO (UTILIZAR O VALOR ATUAL)-----------------------------------------------|");
                                                                                        Console.WriteLine("|_______________________________________________________________________________|");
                                                                                        opcaodolarreal= double.Parse(Console.ReadLine());
                                                                                                    if(opcaodolarreal==1)
                                                                                                        {
                                                                                                            Console.WriteLine(" _______________________________________________________________________________");
                                                                                                            Console.WriteLine("|                                                                               |");
                                                                                                            Console.WriteLine("|--INSIRA O VALOR DA COTAÇÃO DO DÓLAR :                                         |");                                  
                                                                                                            Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                            valordolarreal= double.Parse(Console.ReadLine());
                                                                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE REAL PARA DÓLAR///////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM REAIS QUE DESEJA CONVERTER:                                |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor2 = double.Parse(Console.ReadLine());

                                                                                                                valor2 = valor2 / valordolarreal ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: USD ${0}.                                               ", valor2);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU DÓLAR-------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedadolar2 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedadolar2 == 1)
                                                                                                                        {
                                                                                                                            goto menudolar2;
                                                                                                                        }
                                                                                                                    else if(opcaomoedadolar2 == 2)
                                                                                                                        {
                                                                                                                            goto menudolar;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menudolar2;
                                                                                                                        }
                                                                                                        }
                                                                                                    else if(opcaodolarreal==2)
                                                                                                        {
                                                                                                            valordolarreal = 4.83;
                                                                                                            Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE REAL PARA DÓLAR///////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM REAIS QUE DESEJA CONVERTER:                                |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor2 = double.Parse(Console.ReadLine());

                                                                                                                valor2 = valor2 / valordolarreal ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: USD ${0}.                                            ", valor2);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU DÓLAR-------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedadolar2 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedadolar2 == 1)
                                                                                                                        {
                                                                                                                            goto menudolar2;
                                                                                                                        }
                                                                                                                    else if(opcaomoedadolar2 == 2)
                                                                                                                        {
                                                                                                                            goto menudolar;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menudolar2;
                                                                                                                        }
                                                                                                        }
                                                                                                    else
                                                                                                        {
                                                                                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                             goto menudolar1;
                                                                                                        }
                                                                                break;//FIM DO CONVERSOR DE REAL PARA DÓLAR

                                                                                case 3://VOLTAR PARA O MENU DE CONVERSOR DE MOEDAS
                                                                                    goto menumoeda; 
                                                                                break;

                                                                                default:
                                                                                    Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                    goto menudolar; //voltar para o conversor de dólar
                                                                                break;
                                                                    }// Fim do escolha conversor dólar 
                                                         break;
                                                                
                                                         case 2://INCIO DO CONVERSOR DE EURO

                                                                menueuro:
                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|//////////////////////////////CONVERSOR DE EURO////////////////////////////////|");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                                                                Console.WriteLine("|                                                                               |");
                                                                Console.WriteLine("|-----1-EURO PARA REAL----------------------------------------------------------|");
                                                                Console.WriteLine("|-----2-REAL PARA EURO----------------------------------------------------------|");
                                                                Console.WriteLine("|-----3-VOLTAR AO MENU ANTERIOR-------------------------------------------------|");
                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                opcaomoedaeuro = int.Parse(Console.ReadLine());

                                                                switch(opcaomoedaeuro)
                                                                    {
                                                                                case 1://INICIO DO CONVERSOR DE EURO PARA REAL
                                                                                    menueuro1:
                                                                                    Double valor3, valoreuro, opcaomoedaeuro1, opcaoeuro;
                                                                                        Console.WriteLine(" _______________________________________________________________________________");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|/////////////////////////CONVERSOR DE EURO PARA REAL///////////////////////////|");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|------------------Atualmente EUR €1 Euro equivale a BRL R$5,11.----------------|");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--Deseja alterar o valor da cotação para a conversão ?                         |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--1-SIM (ALTERAR VALOR DA COTAÇÃO)---------------------------------------------|");
                                                                                        Console.WriteLine("|--2-NÃO (UTILIZAR O VALOR ATUAL)-----------------------------------------------|");
                                                                                        Console.WriteLine("|_______________________________________________________________________________|");
                                                                                        opcaoeuro= double.Parse(Console.ReadLine());
                                                                                                    if(opcaoeuro==1)
                                                                                                        {
                                                                                                            Console.WriteLine(" _______________________________________________________________________________");
                                                                                                            Console.WriteLine("|                                                                               |");
                                                                                                            Console.WriteLine("|--INSIRA O VALOR DA COTAÇÃO DO EURO :                                          |");                                  
                                                                                                            Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                            valoreuro= double.Parse(Console.ReadLine());
                                                                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE EURO PARA REAL////////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM EUROS QUE DESEJA CONVERTER:                                |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor3 = double.Parse(Console.ReadLine());

                                                                                                                valor3 = valor3 * valoreuro ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: R${0}.                                                ", valor3);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU EURO--------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedaeuro1 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedaeuro1 == 1)
                                                                                                                        {
                                                                                                                            goto menueuro1;
                                                                                                                        }
                                                                                                                    else if(opcaomoedaeuro1 == 2)
                                                                                                                        {
                                                                                                                            goto menueuro;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menueuro1;
                                                                                                                        }
                                                                                                        }
                                                                                                    else if(opcaoeuro==2)
                                                                                                        {
                                                                                                            valoreuro = 5.11;
                                                                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE EURO PARA REAL////////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM EUROS QUE DESEJA CONVERTER:                                |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor3 = double.Parse(Console.ReadLine());

                                                                                                                valor3 = valor3 * valoreuro ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: R${0}.                                                ", valor3);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU EURO--------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedaeuro1 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedaeuro1 == 1)
                                                                                                                        {
                                                                                                                            goto menueuro1;
                                                                                                                        }
                                                                                                                    else if(opcaomoedaeuro1 == 2)
                                                                                                                        {
                                                                                                                            goto menueuro;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menueuro1;
                                                                                                                        }
                                                                                                        }
                                                                                                    else
                                                                                                        {
                                                                                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                             goto menueuro1;
                                                                                                        }
                                                              
                                                                                break;//FIM DO COVERSOR DE EURO PARA REAL
                                                   

                                                                                case 2://INICIO DO CONVERSOR DE REAL PARA EURO
                                                                                             menueuro2:
                                                                                        Double valor4, valoreuroreal, opcaomoedaeuro2, opcaoeuroreal;
                                                                                        Console.WriteLine(" _______________________________________________________________________________");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|/////////////////////////CONVERSOR DE REAL PARA EURO///////////////////////////|");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--------------------Atualmente BRL R$ 1 equivale a EUR €0,19.------------------|");
                                                                                        Console.WriteLine("|                                (EUR€ 1 = R$5,11)                              |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--Deseja alterar o valor da cotação para a conversão ?                         |");
                                                                                        Console.WriteLine("|                                                                               |");
                                                                                        Console.WriteLine("|--1-SIM (ALTERAR VALOR DA COTAÇÃO)---------------------------------------------|");
                                                                                        Console.WriteLine("|--2-NÃO (UTILIZAR O VALOR ATUAL)-----------------------------------------------|");
                                                                                        Console.WriteLine("|_______________________________________________________________________________|");
                                                                                        opcaoeuroreal= double.Parse(Console.ReadLine());
                                                                                                    if(opcaoeuroreal==1)
                                                                                                        {
                                                                                                            Console.WriteLine(" _______________________________________________________________________________");
                                                                                                            Console.WriteLine("|                                                                               |");
                                                                                                            Console.WriteLine("|--INSIRA O VALOR DA COTAÇÃO DO EURO:                                           |");                                  
                                                                                                            Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                            valoreuroreal= double.Parse(Console.ReadLine());
                                                                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE REAL PARA EURO////////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM REAIS QUE DESEJA CONVERTER:                                |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor4 = double.Parse(Console.ReadLine());

                                                                                                                valor4 = valor4 / valoreuroreal ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: EUR €{0}.                                            ", valor4);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU EURO--------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedaeuro2 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedaeuro2 == 1)
                                                                                                                        {
                                                                                                                            goto menueuro2;
                                                                                                                        }
                                                                                                                    else if(opcaomoedaeuro2 == 2)
                                                                                                                        {
                                                                                                                            goto menueuro;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menueuro2;
                                                                                                                        }
                                                                                                        }
                                                                                                    else if(opcaoeuroreal==2)
                                                                                                        {
                                                                                                            valoreuroreal = 5.11;
                                                                                                                Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|////////////////////////CONVERSOR DE REAL PARA EURO////////////////////////////|");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|--DIGITE O VALOR EM REAIS QUE DESEJA CONVERTER:                                |");
                                                                                                                Console.WriteLine("|                                                                               |");
                                                                                                                Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                valor4 = double.Parse(Console.ReadLine());

                                                                                                                valor4 = valor4 / valoreuroreal ;
                                                                                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--O valor da conversão é: EUR €{0}.                                            ", valor4);
                                                                                                                    Console.WriteLine("|                                                                               |");
                                                                                                                    Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|--2-VOLTAR AO MENU EURO--------------------------------------------------------|");
                                                                                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                                                                                    opcaomoedaeuro2 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                                                                                     if(opcaomoedaeuro2 == 1)
                                                                                                                        {
                                                                                                                            goto menueuro2;
                                                                                                                        }
                                                                                                                    else if(opcaomoedaeuro2 == 2)
                                                                                                                        {
                                                                                                                            goto menueuro;
                                                                                                                        }
                                                                                                                    else
                                                                                                                        {
                                                                                                                             Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                                             goto menueuro2;
                                                                                                                        }
                                                                                                        }
                                                                                                    else
                                                                                                        {
                                                                                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                                             goto menueuro1;
                                                                                                        }
                                                                                break;//FIM DO CONVERSOR DE REAL PARA EURO

                                                                                case 3://VOLTAR PARA O MENU DE CONVERSOR DE MOEDAS
                                                                                    goto menumoeda; 
                                                                                break;

                                                                                default:
                                                                                    Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                                    goto menueuro; //voltar para o conversor de euro
                                                                                break;
                                                                    }// Fim do escolha conversor euro
                                                         break;

                                                         case 3://VOLTAR AO MENU PRINCIPAL
                                                                goto menu; 
                                                         break;

                                                         default:
                                                               Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                               goto menumoeda; //VOLTAR PARA O CONVERSOR DE MOEDAS
                                                          break;
                                    }
                    break;//FIM DO CONVERSOR DE MOEDAS

                    case 3://INICIO DO CONVERSOR DE PESO
                        menupeso:
                            Console.WriteLine(" _______________________________________________________________________________");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|/////////////////////////////CONVERSOR DE PESO/////////////////////////////////|");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|Por favor escolha uma opção:                                                   |");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|-----1-CONVERSOR DE QUILO PARA GRAMA-------------------------------------------|");
                            Console.WriteLine("|-----2-CONVERSOR DE GRAMA PARA QUILO-------------------------------------------|");
                            Console.WriteLine("|-----3-VOLTAR AO MENU PRINCIPAL------------------------------------------------|");
                            Console.WriteLine("|_______________________________________________________________________________|");
                            opcaopeso = int.Parse(Console.ReadLine());

                                    switch (opcaopeso)
                                    {
                                        
                                        case 1:
                                            menupeso1:
                                        double valorpeso1, opcaopeso1;
                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                    Console.WriteLine("|                                                                               |");
                                                    Console.WriteLine("|/////////////////////////CONVERSOR DE QUILO PARA GRAMA/////////////////////////|");
                                                    Console.WriteLine("|                                                                               |");
                                                    Console.WriteLine("|-Digite o valor em quilos que deseja ser convertido:                           |");                                        
                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                    valorpeso1 = double.Parse(Console.ReadLine());
                                                    valorpeso1 = valorpeso1 * 1000;
                                                    
                                                              Console.WriteLine(" _______________________________________________________________________________");
                                                              Console.WriteLine("|                                                                               |");
                                                              Console.WriteLine("|--O valor da conversão é: {0} G.                                                ", valorpeso1);
                                                              Console.WriteLine("|                                                                               |");
                                                              Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                              Console.WriteLine("|--2-VOLTAR AO MENU PESO--------------------------------------------------------|");
                                                              Console.WriteLine("|_______________________________________________________________________________|");
                                                              opcaopeso1 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                             if(opcaopeso1 == 1)
                                                              {
                                                                    goto menupeso1;
                                                              }
                                                             else if(opcaopeso1 == 2)
                                                              {
                                                                    goto menupeso;
                                                              }
                                                              else
                                                              {
                                                                    Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                    goto menupeso1;
                                                              }
                                                    
                                            break;

                                        case 2:
                                            menupeso2:
                                         double valorpeso2, opcaopeso2;
                                                    Console.WriteLine(" _______________________________________________________________________________");
                                                    Console.WriteLine("|                                                                               |");
                                                    Console.WriteLine("|/////////////////////////CONVERSOR DE GRAMA PARA QUILO/////////////////////////|");
                                                    Console.WriteLine("|                                                                               |");
                                                    Console.WriteLine("|-Digite o valor em gramas que deseja ser convertido:                           |");                                        
                                                    Console.WriteLine("|_______________________________________________________________________________|");
                                                    valorpeso2 = int.Parse(Console.ReadLine());
                                                    valorpeso2 = valorpeso2 / 1000;
                                                    
                                                              Console.WriteLine(" _______________________________________________________________________________");
                                                              Console.WriteLine("|                                                                               |");
                                                              Console.WriteLine("|--O valor da conversão é: {0} Kgs.                                             ", valorpeso2);
                                                              Console.WriteLine("|                                                                               |");
                                                              Console.WriteLine("|--1-FAZER OUTRA CONVERSÃO------------------------------------------------------|");
                                                              Console.WriteLine("|--2-VOLTAR AO MENU PESO--------------------------------------------------------|");
                                                              Console.WriteLine("|_______________________________________________________________________________|");
                                                              opcaopeso2 = int.Parse(Console.ReadLine());
                                                                                                                    
                                                             if(opcaopeso2 == 1)
                                                              {
                                                                    goto menupeso2;
                                                              }
                                                             else if(opcaopeso2 == 2)
                                                              {
                                                                    goto menupeso;
                                                              }
                                                              else
                                                              {
                                                                    Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                                                    goto menupeso2;
                                                              }
                                                    
                                            break;

                                        case 3:
                                            goto menu;
                                            break;

                                        default:
                                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                                            goto menupeso;
                                            break;
                                    }

                    break;//FIM DO CONVERSOR DE PESO

                    case 4:
                            Console.WriteLine(" _______________________________________________________________________________");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|//////////////////////////////////CONVERSOR////////////////////////////////////|");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|-----------------------------Obrigado, volte sempre----------------------------|");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|      Nome: Rafael Costa Silva, Cassiano Hideki, Marcelo Miayajima             |");
                            Console.WriteLine("|      RGM: 11221400214, 112121101074, 11212101319                              |");
                            Console.WriteLine("|                                                                               |");
                            Console.WriteLine("|_______________________________________________________________________________|");
                            Environment.Exit(0);
                    break;

                    default:
                            Console.WriteLine("//////////////////////////Por favor, digite um código válido!!////////////////////////////");
                    goto menu;
                    break;
            }
        }
    }
}