using System;
using System.Globalization;

class minhaClasse
{

    /*
    PROBLEMA
    Saber sobre as taxas de crescimento das cidades.
    De acordo com dados da população e a taxa de crescimento de duas cidades quaisquer (A e B)
    Calcular quantos anos levará para que a cidade menor (A) cresça mais em população que a cidade maior (B).
    Informar apenas as cidades onde A for maior que B.
    Apresentar o tempo em anos para cada caso.
    ENTRADA
    A primeira linha da entrada contém um único inteiro T, indicando o número de casos 
    de teste (1 ≤ T ≤ 3000). Cada caso de teste contém 4 números: dois inteiros PA e PB 
    (100 ≤ PA < 1000000, PA < PB ≤ 1000000) indicando respectivamente a população de A e 
    B, e dois valores G1 e G2 (0.1 ≤ G1 ≤ 10.0, 0.0 ≤ G2 ≤ 10.0, G2 < G1) com um digito 
    após o ponto decimal cada, indicando respectivamente o crescimento populacional de
     A e B (em percentual). 
    SAÍDA
    Imprima, para cada caso de teste, quantos anos levará para que a cidade A ultrapasse 
    a cidade B em número de habitantes. Obs.: se o tempo for mais do que 100 anos o 
    programa deve apresentar a mensagem: Mais de 1 seculo. Neste caso, é melhor 
    interromper o programa imediatamente após passar de 100 anos, caso contrário você 
    poderá receber como resposta da submissão deste problema "Time Limit Exceeded".
     */



    static void Main(string[] args)
    {

        int t = Convert.ToInt32(Console.ReadLine());
        double[] arrayList = new double[4];
        int pa = 0;
        int pb = 0;
        double cpa = 0;
        double cpb = 0;
        int anos;

        for (int i = 0; i < t; i++)
        {
            anos = 0;
            string[] valores = Console.ReadLine().Split();

            pa = (int.Parse(valores[0]));
            pb = (int.Parse(valores[1]));
            cpa = (double.Parse(valores[2], CultureInfo.InvariantCulture));
            cpb = (double.Parse(valores[3], CultureInfo.InvariantCulture));

            while (pa <= pb)
            {
                anos++;

                pa += (int)Math.Floor((cpa / 100) * pa);
                pb += (int)Math.Floor((cpb / 100) * pb);

                if (anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                    break;
                }
            }
            if (anos <= 100)
            {
                Console.WriteLine("{0} anos.", anos);
            }

        }
    }

}