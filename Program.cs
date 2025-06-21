class ProgramaMonstro
{
    static void Main()
    {
        Console.WriteLine("--- Noite de Terror ---");
        Console.WriteLine("Descubra qual o mostro que perseguirá a vítima de acordo com uma data de nascimento.");

        Console.Write("Qual o dia de nascimento da vítima (1 a 31):");
        int dia = int.Parse(Console.ReadLine()!);

        Console.Write("Qual o mês de nascimento da vítima (1 a 12):");
        int mes = int.Parse(Console.ReadLine()!);


        Console.WriteLine($"A vítima nasceu no dia {dia} de {mes}.");

        Console.WriteLine("O monstro que perseguirá a vítima é:");
        Console.WriteLine($"{DescobrirMonstroPorDia(dia)} {DescobrirMonstroPorMes(mes)}");
    }

    static string DescobrirMonstroPorDia(int dia)
    {
        int chave = (dia) % 12;

        switch (chave)
        {
            case 1: return "Zumbi";
            case 2: return "Assassino";
            case 3: return "Psicopata";
            case 4: return "Alienígena";
            case 5: return "Psicopata";
            case 6: return "Matador";
            case 7: return "Vampiro";
            case 8: return "Maluco";
            case 9: return "Maluco";
            case 10: return "Monstro";
            case 11: return "Bruxo";
            case 0: return "Demônio";
            default: return "Desconhecido";
        }
    }

    static string DescobrirMonstroPorMes(int mes)
    {
        switch (mes)
        {
            case 1: return "Endiabrado";
            case 2: return "Radioativo";
            case 3: return "Endemoniado";
            case 4: return "Vermelho";
            case 5: return "Possuído";
            case 6: return "Macabro";
            case 7: return "Sombrio";
            case 8: return "Sem Cabeça";
            case 9: return "Maluco";
            case 10: return "Desconhecido";
            case 11: return "Inconsciente";
            case 12: return "Oculto";
            case 13: return "Esquecido";
            case 14: return "Invocado";
            case 15: return "Caído";
            case 16: return "Costurado";
            case 17: return "Amaldiçoado";
            case 18: return "Anormal";
            case 19: return "Perturbado";
            case 20: return "Sanguinário";
            case 21: return "Tenebroso";
            case 22: return "Imortal";
            case 23: return "Ressuscitado";
            case 24: return "do Pântano";
            case 25: return "da Encruzilhada";
            case 26: return "do Porão";
            case 27: return "do Velho Poço";
            case 28: return "sem Perdão";
            case 29: return "do Cemitério";
            case 30: return "da Meia-Noite";
            case 31: return "da Lua Cheia";
            default: return "Desconhecido";
        }
    }
}


