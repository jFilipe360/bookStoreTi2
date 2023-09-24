using bookStore.Data.Enums;
using bookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookStore.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Escritores
                if(!context.Escritores.Any())
                {
                    context.Escritores.AddRange(new List<Escritor>()
                    {
                        new Escritor()
                        {
                            NomeCompleto = "Arthur Conan Doyle",
                            Biografia = "Arthur Conan Doyle (1859-1930) foi um escritor escocês. Além de histórias policiais, escreveu também ficção científica, romances históricos, peças de teatro e poesia. Em 1876, entrou na Universidade de Edimburgo, concluindo o curso de Medicina em 1881. Entre 1882 e 1891, exerceu a profissão em Southsea, Inglaterra.",
                            URLFoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bb/Conan_doyle.jpg/1200px-Conan_doyle.jpg"
                        },
                        new Escritor()
                        {
                            NomeCompleto = "José Saramago",
                            Biografia = "José Saramago (1922-2010) foi um importante escritor português. Destacou-se como romancista, teatrólogo, poeta e contista. Recebeu o Prêmio Nobel de Literatura o Prêmio Camões..\r\n\r\nJosé Saramago nasceu em Azinhaga de Ribatejo, no concelho de Golegã, distrito de Santarém. Portugal, no dia 16 de novembro de 1922. Filho de camponeses com dois anos de idade mudou-se com a família para Lisboa.",
                            URLFoto = "https://s.ebiografia.com/assets/img/authors/jo/se/jose-saramago-2-l.jpg?auto_optimize=low&width=255"
                        },
                        new Escritor()
                        {
                            NomeCompleto = "Mark Twain",
                            Biografia = "Mark Twain é considerado o pai da literatura americana moderna e deu vida a dois dos mais importantes e carismáticos personagens americanos de livros infantis, Huckleberry Finn e seu amigo Tom Sawyer. Faleceu em Redding, em Connecticut, Estados Unidos, no dia 21 de abril de 1910.",
                            URLFoto = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/Mark_Twain_by_AF_Bradley.jpg/375px-Mark_Twain_by_AF_Bradley.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                //Editoras
                if (!context.Editoras.Any())
                {
                    context.Editoras.AddRange(new List<Editora>()
                    {
                        new Editora()
                        {
                            NomeEditora = "Penguin Books",
                            URLLogo = "https://upload.wikimedia.org/wikipedia/pt/thumb/1/1c/Penguin_logo.svg/354px-Penguin_logo.svg.png?20220424052855",
                            AnoFundacao = 1935,
                            Slogan = "Free Expression & Joy of Reading",
                            Website = "https://www.penguinlivros.pt"
                        },
                        new Editora()
                        {
                            NomeEditora = "Pan Macmillan",
                            URLLogo = "https://assets-eu-01.kc-usercontent.com/d554c971-bcd0-014b-bb17-d2b96b437da4/32d39530-ebe8-40f3-a495-c443332b1c08/PM-Logo.jpg",
                            AnoFundacao = 1843,
                            Slogan = "Diversity in our books",
                            Website = "https://www.panmacmillan.com"
                        },
                        new Editora()
                        {
                            NomeEditora = "Porto Editora",
                            URLLogo = "https://www.portoeditora.pt/responsive/pe_logoBlack.png",
                            AnoFundacao = 1944,
                            Slogan = "Abre horizontes",
                            Website = "https://www.portoeditora.pt"
                        }
                    });
                    context.SaveChanges();
                }

                //
                if (!context.Livros.Any())
                {
                    context.Livros.AddRange(new List<Livro>()
                    {
                        new Livro()
                        {
                            Titulo = "Adventures Of Huckleberry Finn",
                            Sinopse = "When Huck escapes from his drunken father and the \"sivilizing\" Widow Douglas with the runaway slave Jim, he embarks on a series of adventures that draw him to feuding families and the trickery of the unscrupulous \"Duke\" and \"Dauphin\".",
                            Preco = 5.40,
                            URlImagem = "https://images.randomhouse.com/cover/9780141439648",
                            DataLancamento = 2003,
                            EditoraId = 1,
                            EscritorId = 3,
                            LivroCategora = LivroCategoria.Ficção
                        },
                        new Livro()
                        {
                            Titulo = "O Ano da Morte de Ricardo Reis",
                            Sinopse = "Um tempo múltiplo. Labiríntico. As histórias das sociedades humanas. Ricardo Reis chega a Lisboa em finais de dezembro de 1935. Fica até setembro de 1936. Uma personagem vinda de uma outra ficção, a da heteronímia de Fernando Pessoa. E um movimento inverso, logo a começar: «Aqui onde o mar se acaba e a terra principia»; o virar ao contrário o verso de Camões: «Onde a terra acaba e o mar começa.» Em Camões, o movimento é da terra para o mar; no livro de Saramago temos Ricardo Reis a regressar a Portugal por mar. É substituído o movimento épico da partida. Mais uma vez, a história na escrita de Saramago. E as relações entre a vida e a morte. Ricardo Reis chega a Lisboa em finais de dezembro e Fernando Pessoa morreu a 30 de novembro. Ricardo Reis visita-o ao cemitério. Um tempo complexo. O fascismo consolida-se em Portugal.",
                            Preco = 14.20,
                            URlImagem = "https://img.wook.pt/images/o-ano-da-morte-de-ricardo-reis-jose-saramago/MXwxODQ5MzUwOXwyNDIzMDA5MnwxNjcwOTQ1Njg3MDAwfHdlYnA=/550x",
                            DataLancamento = 1984,
                            EditoraId = 3,
                            EscritorId = 2,
                            LivroCategora = LivroCategoria.Romance
                        },
                        new Livro()
                        {
                            Titulo = "A Study In Scarlet And The Sign Of The Four",
                            Sinopse = "Two novels featuring Sherlock Holmes and Dr Watson in a pocket hardback edition",
                            Preco = 9.91,
                            URlImagem = "https://img.wook.pt/images/a-study-in-scarlet-and-the-sign-of-the-four-arthur-conan-doyle/MXwxNzAzNTEzN3wxMjY1ODI3OHwxNjgyNTg0OTQ0MDAwfHdlYnA=/550x",
                            DataLancamento = 2016,
                            EditoraId = 2,
                            EscritorId = 1,
                            LivroCategora = LivroCategoria.Ficção
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
