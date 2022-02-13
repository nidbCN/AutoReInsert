using AutoReInsert.Services;
using Topshelf;

HostFactory.Run(config => config.Service<ReInsertService>());