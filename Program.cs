using backand.Classes;

Pessoafisica novaPF  = new Pessoafisica();

novaPF.nome = "Millena menininha s2";
novaPF.cpf = "000.000.000-2";
novaPF.rendimento = 6600.5f;
//Console.WriteLine(novaPF.nome);
//Console.WriteLine(novaPF.cpf);


//pessoa fisica  ============================================
float impostoPagar = novaPF.CalcularImposto (novaPF.rendimento);
Console.WriteLine(impostoPagar);
//pessoa juridica ===========================================
Pessoajuridica novaPJ = new Pessoajuridica();
Console.WriteLine(novaPJ.CalcularImposto(6600.5f));