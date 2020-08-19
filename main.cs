using System;

class MainClass {
	public static void Teste (float numero) {
    //Console.WriteLine ("O número informado foi " + numero);
		Console.WriteLine ("O número informado foi {0} ", numero);

  }

  public static void Main () {
		float numero;
		Console.Write ("Digite um valor: ");
		numero = float.Parse(Console.ReadLine());
    Teste(numero);

  }
}

/*
CONDICIONAIS: if / else
REPETIÇÕES: for / while
ESTRUTURA DE DADOS PRIMITIVAS: (int, float, char, string) []-[,]
*/