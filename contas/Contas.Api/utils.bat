dotnet ef migrations add 'tipo-lancamento' --project "C:\Users\rodri\source\repos\projeto-net6\contas\Contas.EfCore\" --startup-project "C:\Users\rodri\source\repos\projeto-net6\contas\Contas.Api\" --output-dir "C:\Users\rodri\source\repos\projeto-net6\contas\Contas.EfCore.Migrator\Migrations\"

dotnet ef database update --project "C:\Users\rodri\source\repos\projeto-net6\contas\Contas.EfCore\" --startup-project "C:\Users\rodri\source\repos\projeto-net6\contas\Contas.EfCore.Migrator\"  
