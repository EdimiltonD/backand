using backand.Classes;

Pessoafisica novaPF  = new Pessoafisica();
Endereco novoEndPf = new Endereco();

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

Pessoajuridica novaPJ = new Pessoajuridica();
Endereco novoEndPJ  = new Endereco();

novaPJ.nome = "Karbat Associados";
novaPJ.razaoSocial = "Empresa advocacia";
novaPJ.cnpj = "76.535.764/0001-43";

novoEndPJ.Logradouro = "Rua do forno";

novoEndPJ.Complemento = " Conjunto 20";

novaPJ.endereco = novoEndPJ;

Console.WriteLine(@$"
Nome: {novaPJ.nome}
Razão Social: {novaPJ.razaoSocial}
CNPJ: {novaPJ.cnpj}
Valido: {novaPJ.ValidarCnpj(novaPJ.cnpj)}
Rua: {novoEndPJ.Logradouro}
Número: {novoEndPJ.Numero}
Complemento: {novoEndPJ.Complemento}
");

