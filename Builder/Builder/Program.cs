using Builder;

var serwerBuilder = new SerwerBuilder();
serwerBuilder.AddGPUs(5);
serwerBuilder.AddRAM(2048);
serwerBuilder.AddProcessors(3);
serwerBuilder.AddTBDiscSpace(28);
var serwer = serwerBuilder.Build();

serwer.Describe();