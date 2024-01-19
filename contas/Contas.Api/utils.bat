dotnet ef migrations add 'init' --project "C:\Users\rodri\source\repos\contas\Contas.EfCore" --startup-project "C:\Users\rodri\source\repos\contas\Contas.Api" --output-dir "C:\Users\rodri\source\repos\contas\Contas.EfCore.Migrator\Migrations"

dotnet ef database update --project "C:\Users\rodri\source\repos\contas\Contas.EfCore" --startup-project "C:\Users\rodri\source\repos\contas\Contas.EfCore.Migrator" 
