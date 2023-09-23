using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atvdd_21_09_2023
{
    /*
     *  Lista 5 – Coleções
     */
    class Program
    {
        static Timer aTimer;
        static List<int> tempos = new List<int>();

        static int menu()
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1) Inserir um tempo no início da lista               ");
            Console.WriteLine("2) Inserir um tempo no final da lista                ");
            Console.WriteLine("3) Inserir um tempo numa posição específica da lista");
            Console.WriteLine("4) Remover o primeiro tempo da lista (Imprimir o tempo removido)");
            Console.WriteLine("5) Remover o último tempo da lista (Imprimir o tempo removido)");
            Console.WriteLine("6) Remover um tempo de uma posição específica na lista (O usuário deve informar a posição do tempo a ser removido.Imprimir o tempo removido)");
            Console.WriteLine("7) Remover um tempo específico da lista (O usuário deve informar o tempo a ser removido)");
            Console.WriteLine("8) Pesquisar quantas vezes um determinado tempo consta na lista (O usuário deve informar o tempo a ser pesquisado)");
            Console.WriteLine("9) Mostrar todos os tempos da lista");
            Console.WriteLine("10) Mostrar todos os tempos da lista em ordem crescente");
            Console.WriteLine("11) Mostrar todos os tempos da lista em ordem decrescente");
            Console.WriteLine("12) Encerrar o programa\n\n");

            Console.Write("Opção: ");
            return int.Parse(Console.ReadLine());
        }

        static void insereInicio(int hora) // 1
        {
            tempos[0] = hora;
            Console.WriteLine("Tempo inserido no inicio com sucesso!");
        }
        static void insereFinal(int hora) // 2
        {
            tempos[tempos.Count] = hora;
            Console.WriteLine($"Tempo inserido no final com sucesso!");
        }
        static void inserePosicaoEspecifica(int hora, int posicao)  //3
        {
            tempos[posicao] = hora;
            Console.WriteLine($"Tempo inserido na posição {posicao} com sucesso!");
        }
        static void removeInicio() // 4
        {
            int temp = tempos[0];
            tempos.RemoveAt(0);
            Console.WriteLine($"Hora {temp} removida do inicio com sucesso!");
        }
        static void removeFinal() // 5
        {
            int temp = tempos[tempos.Count-1];
            tempos.RemoveAt(tempos.Count - 1);
            Console.WriteLine($"Hora {temp} removida do final com sucesso!");
        }
        static void removePosicaoEspecifica(int posicao) // 6
        {
            int temp = tempos[posicao];
            tempos.RemoveAt(posicao);
            Console.WriteLine($"Hora {temp} removida da posicao {posicao} com sucesso!");
        }

        static void removeHoraEspecifica(int hora) // 7
        {
            int temp = tempos[tempos.IndexOf(hora)];
            tempos.Remove(hora);
            Console.WriteLine($"A hora ${temp} foi removida com sucesso!");
        }

        static int contaEvidencias(int hora) // 8
        {
            int cont = 0;
            foreach(int tempo in tempos)
            {
                if (hora == tempo)
                    cont++;
                
            }
                return cont;
        }

        static void exibeTempos() // 9
        {
            int cont = 0;
            foreach(int tempo in tempos)
            {
                Console.WriteLine($"{++cont}º {tempo}");
            }
        }


        static void exibeTemposOrdemCrescente() // 10
        {
            tempos.Sort();
            foreach(int tempo in tempos)
            {
                Console.WriteLine(tempo);
            }
        }   
        
        static void exibeTemposOrdemDecrescente() // 11
        {
            tempos.Sort();
            tempos.Reverse();
            
            foreach(int tempo in tempos)
            {
                Console.WriteLine(tempo);
            }
        }

        static void Main(string[] args)
        {

            Console.Clear();
            int opicao = menu(), hora;
            int posicao;

            switch (opicao)
            {
                case 1:
                    Console.Write("Informe a hora que será inserida: ");
                    hora = int.Parse(Console.ReadLine());
                    insereInicio(hora);
                    break;
                case 2:
                    Console.Write("Informe a hora que será inserida: ");
                    hora = int.Parse(Console.ReadLine());
                    insereFinal(hora);
                    break;
                case 3:
                    Console.Write("Informe a hora que será inserida: ");
                    hora = int.Parse(Console.ReadLine());
                    Console.Write("Informe a posição que será inserido: ");
                    posicao = int.Parse(Console.ReadLine());

                    inserePosicaoEspecifica(hora, posicao);
                    break;
                case 4:
                    removeInicio();
                    break;
                case 5:
                    removeFinal();
                    break;
                case 6:
                    Console.Write("Informe a posição que deseja remover: ");
                    posicao = int.Parse(Console.ReadLine());
                    removePosicaoEspecifica(posicao);
                    break;
                case 7:
                    Console.Write("Informe o tempo que deseja remover: ");
                    int tempo = int.Parse(Console.ReadLine());
                    removeHoraEspecifica(tempo);
                    break;
                case 8:
                    Console.Write("Informe o tempo que deseja ver as ocorrencias: ");
                    int aux = int.Parse(Console.ReadLine());
                    Console.WriteLine($"A hora {aux} aparece { contaEvidencias(aux) } vezes");
                    break;
                case 9:
                    exibeTempos();
                    break;
                case 10:
                    exibeTemposOrdemCrescente();
                    break;
                case 11:
                    exibeTemposOrdemDecrescente();
                    break;
                case 12: 
                    Console.WriteLine("Obrigado e volte sempre!");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
