using System;
    class Aula15
{   static public void Calculo(int city1, int city2)
    {
        float valor;
        string name1="", name2="";



        switch(city1){
            case 1 : name1 = "Franca";
            break;
            case 2 : name1 = "Ribeirão Preto";
            break;
            case 3 : name1 = "Batatais";
            break;
            case 4 : name1 = "Brodowski";
            break;
            case 5 : name1 = "Campinas";
            break;
        }
        switch(city2){
            case 1 : name2 = "Franca";
            break;
            case 2 : name2 = "Ribeirão Preto";
            break;
            case 3 : name2 = "Batatais";
            break;
            case 4 : name2 = "Brodowski";
            break;
            case 5 : name2 = "Campinas";
            break;
        }

        if (city1 == 1)
        {                                                            
            if(city2 == 2){
            valor = 85.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 3){
            valor = 80.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 4){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 5){
            valor = 90.00f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else {
            Console.WriteLine("Não foi possível calcular a rota,tente novamente.");
            goto var;
            }
        } 
        else if (city1 == 2)
        {                                                            
            if(city2 == 1){
            valor = 85.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 3){
            valor = 70.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 4){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 5){
            valor = 79.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else {
            Console.WriteLine("Não foi possível calcular a rota,tente novamente.");
            goto var;
            }
        } 
        else if (city1 == 3)
        {                                                            
            if(city2 == 1){
            valor = 80.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 2){
            valor = 70.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 4){
            valor = 65.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 5){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else {
            Console.WriteLine("Não foi possível calcular a rota,tente novamente.");
            goto var;
            }
        } 
        else if (city1 == 4)
        {
            if(city2 == 1){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 2){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 3){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 5){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else {
            Console.WriteLine("Não foi possível calcular a rota,tente novamente.");
            goto var;
            }
        } 
        else if (city1 == 5)
        {                                                           
            if(city2 == 1){
            valor = 90.00f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 2){
            valor = 79.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 3){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else if(city2 == 4){
            valor = 75.90f;
            Console.WriteLine("\nValor........:{0:c}", valor);
            } else {
            Console.WriteLine("Não foi possível calcular a rota,tente novamente.");
            goto var;
            }
        }  
        Console.WriteLine("\n\t\tViagem de {0} para {1}\n", name1, name2);
        var: 
        Console.WriteLine("");
    }
    static void Main()
    {
        int city1, city2, opc;
        
        do {
        Console.Clear();

        Console.WriteLine("------------------- DARK SIDE TRIP SÃO PAULO ---------------------\n");
        Console.WriteLine("(1) - Franca\n(2) - Ribeirão Preto\n(3) - Batatais\n(4) - Brodowski\n(5) - Campinas");
        Console.WriteLine("\n\tDigite o número correspondente a sua cidade de partida : ");
        city1 = Convert.ToInt32(Console.ReadLine());

        

        Console.Clear();

        Console.WriteLine("------------------- DARK SIDE TRIP SÃO PAULO ---------------------\n");
        Console.WriteLine("(1) - Franca\n(2) - Ribeirão Preto\n(3) - Batatais\n(4) - Brodowski\n(5) - Campinas");
        Console.WriteLine("\n\tAgora digite o número correspondente a sua cidade de destino : ");
        city2 = Convert.ToInt32(Console.ReadLine());

        

        Console.Clear();
        Calculo(city1,city2);

        
            
        

        Console.Write("Tecle (1) para calcular uma nova rota, ou pressione qualquer tecla para SAIR : ");
        opc = Convert.ToInt32(Console.ReadLine());
        }while (opc == 1);
    }
}
