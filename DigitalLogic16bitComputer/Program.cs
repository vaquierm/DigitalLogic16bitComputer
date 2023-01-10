
using DigitalLogic16bitComputer.components;
using DigitalLogic16bitComputer.components.gates;
using DigitalLogic16bitComputer.components.registers;

var inputD = new Bit();
var clk = new Bit();
var flipFlop = new DFlipFlop(inputD, clk);

Console.WriteLine(flipFlop.Output);

inputD.Value = true;

Console.WriteLine(flipFlop.Output);

clk.Value = true;

Console.WriteLine(flipFlop.Output);

inputD.Value = false;

Console.WriteLine(flipFlop.Output);

clk.Value = false;

Console.WriteLine(flipFlop.Output);

clk.Value = true;

Console.WriteLine(flipFlop.Output);




