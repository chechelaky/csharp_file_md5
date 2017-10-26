/*
 * Criado por SharpDevelop.
 * Usuário: master
 * Data: 25/10/2017
 * Hora: 22:39
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 * 
 * https://www.dotnetperls.com/bufferedstream
 */
using System;
using System.IO;
using System.Security.Cryptography;

namespace md5{
	class Program{
		
		public static readonly HashAlgorithm MD5 = new MD5CryptoServiceProvider();
		public string hash;
		
		public static void Main(string[] args){
			try{
				Console.WriteLine(GetHashFromFile(args[0], MD5));	
			}catch(Exception e){
				Console.WriteLine("@error");
			}
		}
 
		public static string GetHashFromFile(string fileName, HashAlgorithm algorithm){
		  using (var stream = new BufferedStream(File.OpenRead(fileName), 100000000)){
		    return BitConverter.ToString(algorithm.ComputeHash(stream)).Replace("-", string.Empty);
		  }
		}

	}
}

