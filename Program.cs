using backand.Classes;

Console.Clear();

Utils.BarraCarregamento("Carregando");

string? opcao;
do
{
Console.Clear();
Console.Write(@$"
================================================
|        Bem-Vindo ao Sistema de Cadastro      |
|            Pessoa Física & Jurídica          |
================================================
|                                              |
|             1 - Pessoa Física                |
|                                              |
|             2 - Pessoa Jurídica              |
|                                              |
|             0 - Sair                         |
|                                              |
================================================
");

opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine($"Pessoa Fisica");

        PessoaFisica novaPF = new PessoaFisica();
        Endereco novoEndPf = new Endereco();
   
        novaPF.nome = "Tamires";
        novaPF.cpf = "000.000.000-00";
        novaPF.rendimento = 6600.5f;
        novaPF.dataNasc = new DateTime(2000, 10, 01);

        novoEndPf.logradouro = "Rua Exemplo";
        novoEndPf.numero = 280;
        novoEndPf.complemento = "Complemento Exemplo";
        novoEndPf.endComercial = true;

        novaPF.endereco = novoEndPf;

        Console.WriteLine(@$"
        Nome: {novaPF.nome}, 
        Rendimento: {novaPF.rendimento} 
        CPF: {novaPF.cpf} 
        Logradouro: {novaPF.endereco.logradouro}
        Número: {novaPF.endereco.numero}
        ");

        Thread.Sleep(5000);
        break;

    case "2":
        Console.WriteLine($"Pessoa Jurídica");
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();

        novaPj.nome = "Nome PJ";
        novaPj.razaoSocial = "Razão Social PJ";
        novaPj.cnpj = "00.476.645/0001-03";

        novoEndPj.logradouro = "Rua Exemplo";
        novoEndPj.numero = 280;

        novaPj.endereco = novoEndPj;

        Console.WriteLine(@$"
        Nome: {novaPj.nome}
        Razão Social: {novaPj.razaoSocial}
        CNPJ: {novaPj.cnpj}
        Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
        ");
        
        Console.WriteLine($"Tecle Enter para sair");
        Console.ReadLine();
        break;

    case "0":
        Thread.Sleep(1000);
        Utils.BarraCarregamento("Finalizando");        
        break;

    default:
        Console.WriteLine($"Opção Inválida");
        Thread.Sleep(5000);
        break;
}


} while (opcao !="0");


//Pessoafisica novaPF  = new Pessoafisica();
//Endereco novoEndPf = new Endereco();

//novaPF.nome = "Edimilton dias ";
//novaPF.cpf = "000.000.000-2";
//novaPF.rendimento = 6600.5f;
//novaPF.dataNasc = new DateTime (2000, 02, 20);

//novoEndPf.Logradouro = " rua do forno";
//novoEndPf.Numero = 126;
//novoEndPf.Complemento = "Lu gifts";
//novoEndPf.endComercial = true;

//novaPF.endereco = novoEndPf;

//Console.WriteLine($"{novaPF.nome}, {novaPF.endereco}, {novoEndPf.Logradouro}");



//Console.WriteLine(novaPF.nome);
//Console.WriteLine(novaPF.cpf);


//pessoa fisica  ============================================
//float impostoPagar = novaPF.CalcularImposto (novaPF.rendimento);
//Console.WriteLine(impostoPagar);
//pessoa juridica ===========================================
//Pessoajuridica novaPJ = new Pessoajuridica();
//Console.WriteLine(novaPJ.CalcularImposto(6600.5f));

//DateTime temp = new DateTime (2008, 01, 01);
//Console.WriteLine(novaPF.ValidarDataNasc(temp));

//Pessoajuridica novaPJ = new Pessoajuridica();
//Endereco novoEndPJ  = new Endereco();

//novaPJ.nome = "Karbat Associados";
//novaPJ.razaoSocial = "Empresa advocacia";
//novaPJ.cnpj = "76.535.764/0001-43";

//novoEndPJ.Logradouro = "Rua do forno";

//novoEndPJ.Complemento = " Conjunto 20";

//novaPJ.endereco = novoEndPJ;

//Console.WriteLine(@$"
//Nome: {novaPJ.nome}
//Razão Social: {novaPJ.razaoSocial}
//CNPJ: {novaPJ.cnpj}
//Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
//Rua: {novoEndPJ.Logradouro}
//Número: {novoEndPJ.Numero}
//Complemento: {novoEndPJ.Complemento}
//");

