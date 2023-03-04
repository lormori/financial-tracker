// See https://aka.ms/new-console-template for more information

using Autofac;
using FinancialTracker.Autofac;
using FinancialTracker.TransactionProcessors;

ContainerBuilder containerBuilder = new ContainerBuilder();
containerBuilder.RegisterModule<AutofacModule>();
IContainer container = containerBuilder.Build();

// TODO: get a file path
string filePath = "";

ITransactionsProcessor transactionsProcessor = container.Resolve<ITransactionsProcessor>();
transactionsProcessor.Process(filePath);