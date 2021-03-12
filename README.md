Tutorial: https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-with-nunit

1º - criar dirtório chamado "Csharp_WebAPI_NUnit_EF_MySql_NLog".

2º - entrar na pasta:

    cd Csharp_WebAPI_NUnit_EF_MySql_NLog

3º - criar solution:

    dotnet new sln

4º - criar dirtório chamado "Csharp_WebAPI_NUnit_EF_MySql".

5º - entrar na pasta:

    cd Csharp_WebAPI_NUnit_EF_MySql

6º - criar novo projeto com mesmo nome da pasta:

    dotnet new webapi

7º - retorne para o diretório "Csharp_WebAPI_NUnit_EF_MySql":

    cd ..

8º - Execute o seguinte comando para adicionar o projeto de biblioteca de classes à solução:

    dotnet sln add Csharp_WebAPI_NUnit_EF_MySql/Csharp_WebAPI_NUnit_EF_MySql.csproj

9º - Criando o projeto de teste. Crie o diretório TestsCsharp_WebAPI_NUnit_EF_MySql_Tests

10º - entrar na pasta:

    cd Csharp_WebAPI_NUnit_EF_MySql_Tests

11º - criar novo projeto de Testes usando NUnit com mesmo nome da pasta:

    dotnet new nunit

12º -  Agora, adicione a biblioteca de classes PrimeService como outra dependência ao projeto de Testes. Use o comando:

    dotnet add reference ../Csharp_WebAPI_NUnit_EF_MySql/Csharp_WebAPI_NUnit_EF_MySql.csproj

13º - O seguinte esquema mostra o layout da solução final:

    /unit-testing-using-nunit
        unit-testing-using-nunit.sln
        /PrimeService
            Source Files
            PrimeService.csproj
        /PrimeServiceTests
            Test Source Files
            PrimeServiceTests.csproj

15º - Agora é necessário adicionar o projeto de testes na solution. Para isso, retorne ao diretório principal "unit-testing-using-nunit" e execute o seguinte comando:

    dotnet sln add ./Csharp_WebAPI_NUnit_EF_MySql_Tests/Csharp_WebAPI_NUnit_EF_MySql_Tests.csproj

16º - Criando o primeiro teste. Escreva um teste com falha, faça-o ser aprovado e, em seguida, repita o processo. No diretório PrimeServiceTests, renomeie o arquivo UnitTest1.cs para PrimeService_IsPrimeShould.cs e substitua todo o seu conteúdo pelo código a seguir:

17º - O atributo [TestFixture] indica uma classe que contém testes de unidade. O atributo [Test] indica um método que é um método de teste.
Salve esse arquivo e execute dotnet test para compilar os testes e a biblioteca de classes e, em seguida, execute os testes. O executor de teste do NUnit contém o ponto de entrada do programa para executar os testes. dotnet test inicia o executor de teste usando o projeto de teste de unidade que você criou.
O teste falha. Você ainda não criou a implementação.

OBS.: no CLI este comando funciona tanto na pasta da solution quanto na pasta do projeto de teste.

    dotnet test

18º - Faça esse teste ser aprovado escrevendo o código mais simples na classe PrimeService que funciona:

19º - Execute "dotnet test" novamente. Ele executa uma compilação para o projeto PrimeService e, depois, para o projeto PrimeServiceTests. Depois de compilar os dois projetos, ele executará esse teste único. Ele é aprovado.


DICAS CLI:

    dotnet tool install --global <PACKAGE_NAME>
    
    dotnet tool uninstall --global <PACKAGE_NAME>    

    dotnet remove package <PACKAGE_NAME>


DEPENDENCIAS:    

    dotnet tool install --global dotnet-ef --version 3.1.13 (migrations command CLI. sem isso comando não é reconhecido)

    dotnet add package Microsoft.EntityFrameworkCore --version 3.1.13 (DbContext and DbSet classes)

    dotnet add package Microsoft.EntityFrameworkCore.Design --version 3.1.13 (migration passa a funcionar mas reclama que falta a dependencia do Microsoft.EntityFrameworkCore.Design. para padronizar com SQL server e funcionar com template igual do MySql)    

    dotnet add package Pomelo.EntityFrameworkCore.MySql --version 3.2.4 (UseMySql())

    dotnet add package NLog.Web.AspNetCore --version 4.11.0 (for NLog)

    dotnet add package NLog --version 4.7.8 (for NLog)

    

# bugs para corrigir:

saltos de ID automático toda vez que ocorre uma exeção. na tabela de pessoas, a coluna cpf é UNIQUE no banco: 

    ALTER TABLE pessoas ADD UNIQUE (cpf);

toda vez que tenta inserir um cpf duplicado a lib retorna exeção "duplicate entry" e quando coloca cpf novo, cadastra, mas pula para o próximo ID. deveria ser o mesmo ID.



OUTROS TUTORIAIS:

    fluent assertions + Xunit
    https://www.youtube.com/watch?v=7roqteWLw4s
    https://gist.github.com/Elfocrash/101ffc29947832545cdaebcb259c2f44


    https://www.youtube.com/watch?v=9ZvDBSQa_so
    https://www.youtube.com/watch?v=YccmHAOfwEE
    https://github.com/okazakiandre/refatoringdi-mock
    https://www.youtube.com/watch?v=5GhPAM3mW-I


    https://www.youtube.com/watch?v=WWN-9ahbdIU
    


