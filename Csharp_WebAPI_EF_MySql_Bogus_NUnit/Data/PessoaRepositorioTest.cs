using System;
using Data;
using Models;
using Bogus;
using Bogus.Extensions.Brazil;
using NUnit.Framework;

namespace Csharp_WebAPI_EF_MySql_Bogus_NUnit.Data
{
    public enum Sexo
    {
        M,
        F
    }

    [TestFixture]
    public class PessoaRepositorioTest
    {

        // private DataContext context;
        private PessoaRepositorio pr { get; set; }        
        private string[] generos = new string[2] { "M", "F" };
        private Pessoa p1;
        private PessoaPut p2;
        private PessoaPut p3;

        private string GetRandomizerDate()
        {
            DateTime localDate = DateTime.Now;
            var dia = new Bogus.Randomizer().Number(1,31);
            var mes = new Bogus.Randomizer().Number(1,12);
            var ano = new Bogus.Randomizer().Number(1, localDate.Year);
            return ""+ dia +"/" + mes + "/" + ano;
        }

        [SetUp]
        public void Setup()
        {
            // context = new DataContext();
            // pr = new PessoaRepositorio(context);
            // pr = new PessoaRepositorio(new DataContext());
            // p1 = new Pessoa { Nome = NOME_1, Cpf = CPF_1, DataNascimento = DATA_1, Sexo = SEXO_F };
            // p2 = new PessoaPut { Nome = "outro nome", Cpf = CPF_1, DataNascimento = "9/2/1397", Sexo = SEXO_M };
            // p3 = new PessoaPut { Nome = NOME_2, Cpf = CPF_2, DataNascimento = DATA_2, Sexo = SEXO_M };
            // var generos = new[] { "M", "F" };
            // var dia = new Bogus.Randomizer().Number(1,31);
            // var mes = new Bogus.Randomizer().Number(1,12);
            // var ano = new Bogus.Randomizer().Number(1,2021);
            // string bogusRandomizerDate = ""+ dia +"/" + mes + "/" + ano;
            // var faker = new Faker<Pessoa>("pt_BR")                                                
            //                                     .RuleFor(p => p.Nome, f => f.Person.FullName)
            //                                     .RuleFor(p => p.Cpf, f => f.Person.Cpf())
            //                                     // .RuleFor(p => p.DataNascimento, f => f.Date.Past(15))
            //                                     .RuleFor(p => p.DataNascimento, f => bogusRandomizerDate)
            //                                     .RuleFor(p => p.Sexo, f => f.PickRandom(generos));
        }
        
        // .RuleFor(p => p.Cpf, f => new Bogus.Randomizer().Replace("###########"))
        //                                         .RuleFor(p => p.DataNascimento, f => new Bogus.Randomizer().Replace("##/##/####"))

        // [Test, Order(1)]
        // public void GetListPessoaVaziaTest()
        // {
        //     var generos = new[] { "M", "F" };
        //     var dia = new Bogus.Randomizer().Number(1,31);
        //     var mes = new Bogus.Randomizer().Number(1,12);
        //     var ano = new Bogus.Randomizer().Number(1,2021);
        //     string bogusRandomizerDate = ""+ dia +"/" + mes + "/" + ano;
        //     Pessoa faker = new Faker<Pessoa>("pt_BR")                                                
        //                                         .RuleFor(p => p.Nome, f => f.Person.FullName)
        //                                         .RuleFor(p => p.Cpf, f => f.Person.Cpf())
        //                                         // .RuleFor(p => p.DataNascimento, f => f.Date.Past(15))
        //                                         .RuleFor(p => p.DataNascimento, f => bogusRandomizerDate)
        //                                         .RuleFor(p => p.Sexo, f => f.PickRandom(generos));

        //     CollectionAssert.IsEmpty(PessoaRepositorio.GetListPessoa());
        //     NUnit.Framework.TestContext.Progress.WriteLine("OOOOOOOOOOOOOO");
        //     NUnit.Framework.TestContext.Progress.WriteLine(faker.Cpf);
        // }
        // PARA IMPRIMIR NO CONSOLE MENSGEMS DE DEBUG QUANDO EXECUTAR UM TESTE
        // TestContext.Out.WriteLine("Message to write to loOOOOOOOOOOOOOOg");
            // System.Console.WriteLine("ooooooiiiiii");
            // NUnit.Framework.TestContext.Progress.WriteLine("OOOOOOOOOOOOOO");    ESSSE FUNCIONOU

        [Test, Order(1)]
        public void GetListPessoaVaziaTest()
        {
            Pessoa p1 = new Faker<Pessoa>("pt_BR")                                                
                                                .RuleFor(p => p.Nome, f => f.Person.FullName)
                                                .RuleFor(p => p.Cpf, f => f.Person.Cpf())
                                                // .RuleFor(p => p.DataNascimento, f => f.Date.Past(15))
                                                .RuleFor(p => p.DataNascimento, f => GetRandomizerDate())
                                                .RuleFor(p => p.Sexo, f => f.PickRandom(generos));

            // CollectionAssert.IsEmpty(PessoaRepositorio.GetListPessoa());
            NUnit.Framework.TestContext.Progress.WriteLine("OOOOOOOOOOOOOO");
            NUnit.Framework.TestContext.Progress.WriteLine(p1.Nome);
            NUnit.Framework.TestContext.Progress.WriteLine(p1.Cpf);
            NUnit.Framework.TestContext.Progress.WriteLine(p1.DataNascimento);
            NUnit.Framework.TestContext.Progress.WriteLine(p1.Sexo);
        }

        // [Test, Order(2)]
        // public void GetPessoaTestNull()
        // {
        //     Assert.Null(PessoaRepositorio.GetPessoa(CPF_1));
        // }

        // [Test, Order(3)]
        // public void InserirNoBancoDadosTest()
        // {
        //     Assert.IsNotNull(PessoaRepositorio.InserirNoBancoDados(p1));
        // }

        // [Test, Order(4)]
        // public void GetListPessoaTest()
        // {
        //     CollectionAssert.IsNotEmpty(PessoaRepositorio.GetListPessoa());
        // }

        // [Test, Order(5)]
        // public void GetPessoaTest()
        // {
        //     Assert.IsNotNull(PessoaRepositorio.GetPessoa(CPF_1));
        // }

        // [Test, Order(6)]
        // public void AtualizarNoBancoDadosTest()
        // {
        //     Assert.IsNotNull(PessoaRepositorio.AtualizarNoBancoDados(p2));
        // }

        // [Test, Order(7)]
        // public void AtualizarNoBancoDadosNullTest()
        // {
        //     Assert.IsNull(PessoaRepositorio.AtualizarNoBancoDados(p3));
        // }

        // [Test, Order(8)]
        // public void ApagarNoBancoDadosNullTest()
        // {
        //     Assert.IsNull(PessoaRepositorio.ApagarNoBancoDados(CPF_2));
        // }

        // [Test, Order(9)]
        // public void ApagarNoBancoDadosTest()
        // {
        //     Assert.IsNotNull(PessoaRepositorio.ApagarNoBancoDados(CPF_1));
        // }
    }
}