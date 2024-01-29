using System;
using ScreenSound.Shared.Dados;
using ScreenSound.Shared.Modelos;

namespace ScreenSound.Menus
{
	internal class MenuMostrarMusicasPorAno : Menu
	{
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);

            ExibirTituloDaOpcao("Mostrar musicas por ano de lançamento");
            Console.WriteLine("Digite o ano para consultar músicas:");
            string anoLancamento = Console.ReadLine()!;

            var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
            var listaAnoLancamento = musicaDAL.ListarPor(a => a.AnoLancamento == Convert.ToInt32(anoLancamento));
            if (listaAnoLancamento.Any())
            {
                Console.WriteLine($"\nMusicas do Ano {anoLancamento}");
                foreach (var musica in listaAnoLancamento)
                {
                    musica.ExibirFichaTecnica();
                }
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"O ano {anoLancamento} não foi encontrada!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

