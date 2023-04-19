using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaPR21Bim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num, valor, valormaior, valormenor,d, somad, soma, v1,v2,v3, media;

            Console.WriteLine("Escolha um exercício:  ");
            num=int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    //atividade 1

                    Console.WriteLine("Digite um valor inteiro qualquer; ");
                    valor=int.Parse(Console.ReadLine());

                    if (valor < 0)
                    {
                        valor = valor * -1;

                        Console.WriteLine("" + valor);
                    }
                    else
                    {
                        Console.WriteLine("" + valor);
                    }

                    Console.ReadKey();
                    break;    
                    
                case 2:
                    //atividade 2
                    Console.WriteLine("Digite um valor qualquer");
                    valor = int.Parse(Console.ReadLine());

                    if (valor % 3 == 0 && valor % 5 == 0)
                    {
                        Console.WriteLine("Seu valor é multiplo de 3 e de 5");
                    }
                    else if (valor % 4 == 0 && valor % 7 == 0)
                    {
                        Console.WriteLine("Seu valor é multiplo de 4 e de 7");
                    }

                    if(valor % 3 == 0)
                    {
                        Console.WriteLine("Seu valor é divisível por 3");
                    }
                    if(valor % 5 == 0)
                    {
                        Console.WriteLine("Seu valor é divisível por 5"); 
                    }
                    if(valor % 4 == 0)
                    {
                        Console.WriteLine("Seu valor é divisível por 4");
                    }
                    if(valor % 7 == 0)
                    {
                        Console.WriteLine("Seu valor é divisível por 7");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível realizar a divsão");
                    }
                    Console.ReadKey ();
                    break;    
                    
                case 3:
                    Console.WriteLine("Digite o primeiro valor; ");
                    v1=int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo valor; ");
                    v2=int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o terceiro valor; ");
                    v3=int.Parse(Console.ReadLine());
                    
                    if(v1>v2 && v1> v3)
                    {
                        Console.WriteLine("O maior valor é: " + v1);
                    } 
                    else if(v2>v1 && v2> v3)
                    {
                        Console.WriteLine("O maior valor é: " + v2);
                    } 
                    else if(v3>v2 && v3> v1)
                    {
                        Console.WriteLine("O maior valor é: " + v3);
                    }
                    Console.ReadKey();
                     break;           
                    
                case 4:
                    Console.WriteLine("Digite número de 1 a 7:");
                    valor =int.Parse(Console.ReadLine());

                    switch (valor)
                    {
                        case 1:
                            Console.WriteLine("Domingo: gosto de descançar o máximo que posso e de assistir 'a fea mas bela'");
                            Console.ReadKey();
                            break;                        
                        case 2:
                           Console.WriteLine("Segunda-Feira: Filosofia,Português e Matemática");
                           Console.ReadKey();
                            break;                        
                        case 3:
                            Console.WriteLine("Terça-Feira: Química, História e inglês");
                            Console.ReadKey();
                            break;                        
                        case 4:
                            Console.WriteLine("Quarta: Biologia,Português e ProgramaçãoII");
                            Console.ReadKey();
                            break;                        
                        case 5:
                            Console.WriteLine("Quinta: Física, Redes de Computadores e Sociologia");
                            Console.ReadKey();
                            break;                        
                        case 6:
                            Console.WriteLine("Sexta-Feira: Geografia, Matemática e Banco de Dados");
                            Console.ReadKey();
                            break;                        
                        case 7:
                            Console.WriteLine("Sábado: Gosta de fazer todas as tarefas e adiantar minhas responsabilidades ");
                            Console.ReadKey();
                            break;
                            default:
                            Console.ReadKey();
                            break;
                    }
                    break;  
                    
                case 5:
                    i = 1;
                    valormaior = 0;
                    valormenor = 20000;
                    
                    for (;i != 0;) 
                    {
                        if (i > valormaior)
                        {
                            valormaior = i;
                        }
                        else if(i< valormenor)
                        {
                            valormenor = i;
                        }
                        Console.WriteLine("digite um valor");
                        i = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("O maior valor apresentado na sequência foi: " + valormaior); 
                    Console.WriteLine("O menor valor apresentado na sequência foi: " + valormenor);

                    Console.ReadKey();
                    break;       
                    
                case 6:
                    i = 1
                        ;
                    somad = 0;
                   
                    Console.WriteLine("Digite um valor qualquer: ");
                    valor=int.Parse(Console.ReadLine());

                    for (; somad < valor; i++) 
                    {
                        
                        if (valor % i == 0 )
                        {
                            somad += i;
                        }

                    }

                    if (somad == valor)
                    {
                        Console.WriteLine("Seu valor é um número perfeito");
                    }
                    else
                    {
                        Console.WriteLine("Seu valor não é um número perfeito");
                    }
                    Console.ReadKey ();
                    break;    
                    
                case 7:
                    valor = 1;
                    d = 0;
                    soma = 0;
                    
                    
                    for (; valor != 0;) 
                    {
                        

                        if (valor % 2 == 0)
                        {
                            soma += valor;
                            d ++;
                        }
                        Console.WriteLine("Digite um número qualquer: ");
                        valor = int.Parse(Console.ReadLine());
                    }

                    media = soma / d;

                    if (soma == 0)
                    {
                        Console.WriteLine("Não foi possível calcular a media, pois não houve números pares na sequência apresentada.");
                    }
                    else
                    {
                        Console.WriteLine("Sua média aritmética dos números pares da sequência é de: " + media );
                    }
                    
                    Console.ReadKey ();
                    break;

                default:
                    Console.WriteLine("Erro, tente novamente");
                    Console.ReadKey();
                    break;
            }




























        }
    }
}
