using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            // 1)	Ler o nome de 2 times e o número de gols marcados na partida (para cada time).
            // Escrever o nome do vencedor.Caso não haja vencedor deverá ser impressa a palavra EMPATE.

            //string time1, time2;
            //int gol1, gol2;

            //Console.WriteLine("Qual o nome do seu time? ");
            //time1 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Quantos gols foram marcados pelo " + time1 + " ?");
            //gol1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Qual o nome do time adversário? ");
            //time2 = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("Quantos gols foram marcados pelo time " + time2 + " ?");
            //gol2 = Convert.ToInt32(Console.ReadLine());

            //if (gol1 > gol2)
            //{
            //    Console.WriteLine("O time " + time1 + " foi o vencedor da partida");
            //}
            //else if (gol1 < gol2)
            //{
            //    Console.WriteLine("O time " + time2 + " foi o vencedor da partida");
            //}
            //else if (gol1 == gol2)
            //{
            //    Console.Write("Essa partida terminou em empate!");
            //}
            //Console.ReadKey();


            // 2)  Fazer um programa que solicite salário líquido e o valor da prestação. Se a prestação for maior que 30 % do salário,
            //     o algoritmo deverá imprimir: Empréstimo não pode ser concedido.Caso contrário imprimir Empréstimo pode ser concedido.

            //double salario, prestacao, p_salario, p_prestacao, emprestimo;

            //Console.Write("Qual o valor do seu salário atualmente R$");
            //salario = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Qual o valor pretende fazer em relação ao empréstimo R$");
            //emprestimo = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Em quantas vezes gostaria de dividir esse empréstimo: ");
            //prestacao = Convert.ToDouble(Console.ReadLine());


            //p_prestacao = emprestimo / prestacao;
            //p_salario = salario * 0.3;


            //if (p_prestacao > p_salario)
            //{
            //    Console.WriteLine("Você não pode receber o empréstimo de R$ " + emprestimo + " em " + prestacao + "x.");
            //    Console.WriteLine("Pois a prestação é superior a 30% do salário.");
            //}
            //else if (p_prestacao <= p_salario)
            //{
            //    Console.WriteLine("O empréstimo foi condedido no valor de: R$" + emprestimo + " em " + prestacao + "x.");
            //    Console.WriteLine("Pois a prestação não ultrapassou 30% do valor do seu salário.");
            //}
            //Console.ReadKey();



            //  3)	Uma Seguradora está concedendo descontos dependendo da idade e sexo de seus assegurados.
            //      Escreva um programa que leia o nome, a idade e o sexo do assegurado e escreva o desconto concedido em porcentagem segundo a tabela:
            //
            //        Feminino Masculino
            //        Entre 18 e 25 anos  4 % 3 %
            //        Entre 26 e 55 anos  7 % 6 %
            //        Acima de 55 anos    10 % 9 %

            //string nome, sexo;
            //int idade;

            //Console.Write("Olá prezado cliente, poderia digitar seu nome: ");
            //nome = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("Qual sua idade " + nome + "?");
            //idade = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Poderia informar também qual seu sexo: ");
            //Console.WriteLine("M = Masculino.");
            //Console.WriteLine("F = Feminino.");
            //sexo = Convert.ToString(Console.ReadLine());

            //if (sexo == "M" || sexo == "m")
            //{
            //    if (idade < 18)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Você ainda contém descontos!");
            //    }
            //    else if (idade >= 18 && idade <= 25)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Foi concedido um desconto de 3% para o Sr." + nome);
            //    }
            //    else if (idade >= 26 && idade <= 55)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Foi concedido um desconto de 6% para o Sr." + nome);
            //    }
            //    else if (idade > 55)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Foi concedido um desconto de 9% para o Sr." + nome);
            //    }
            //}
            //else if (sexo == "F" || sexo == "f")
            //{
            //    if (idade < 18)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Você ainda não contém descontos!");
            //    }
            //    else if (idade >= 18 && idade <= 25)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Foi concedido um desconto de 4% para a Sra." + nome);
            //    }
            //    else if (idade >= 26 && idade <= 55)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Foi concedido um desconto de 7% para a Sra." + nome);
            //    }
            //    else if (idade > 55)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Foi concedido um desconto de 10% para a Sra." + nome);
            //    }
            //    }
            //Console.ReadKey();



            //  4)	Uma quitanda está vendendo frutas com a seguinte tabela de preços:

            //              Até 5 Kg             Acima de 5 Kg
            //      Morango R$ 7,50 por Kg       R$ 7,20 por Kg
            //       Manga R$ 6,80 por Kg        R$ 6,50 por Kg

            //  Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 30,00,
            //  receberá ainda um desconto de 10 % sobre este total.
            //  Escreva um algoritmo para ler a quantidade(em Kg) de morangos e a quantidade(em Kg) de mangas adquiridas
            //  e escreva o valor a ser pago pelo cliente.


            //double kg_morango, kg_manga, preco_morango = 0 , preco_manga = 0 , preco_total = 0 , desconto, kg;

            //Console.WriteLine("Olá, qual a quantidade em kg que você comprou em morango?");
            //kg_morango = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Qual a quantidade em kg que você comprou em manga?");
            //kg_manga = Convert.ToDouble(Console.ReadLine());

            //kg = kg_morango + kg_manga;


            //if (kg <= 5)
            //{
            //    preco_morango = kg_morango * 7.5;
            //    preco_manga = kg_manga * 6.8;
            //    preco_total = preco_manga + preco_morango;

            //}
            //else if (kg > 5)
            //{
            //    preco_morango = kg_morango * 7.2;
            //    preco_manga = kg_manga * 6.5;
            //    preco_total = preco_manga + preco_morango;

            //}
            //Console.Clear();
            //Console.WriteLine("Preço dos morangos R$" + preco_morango);
            //Console.WriteLine("Preço das mangas R$" + preco_manga);
            //Console.WriteLine("Preço total das frutas R$" + preco_total);

            //    if (preco_total > 30)
            //    {
            //    Console.WriteLine("Pelo valor total ter ultrapassado R$30,00 recebeu um desconto de 10% na compra pelas frutas.");
            //    desconto = preco_total * 0.1;
            //    preco_total = preco_total - desconto;
            //    Console.WriteLine("E com o desconto, deverá pagar R$" + preco_total);
            //    }
            //    Console.ReadKey();
        }   


    }
}
