<a name='assembly'></a>
# DigitalLogic16bitComputer

## Contents

- [AndGate](#T-DigitalLogic16bitComputer-components-gates-AndGate 'DigitalLogic16bitComputer.components.gates.AndGate')
  - [#ctor(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-AndGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.AndGate.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [#ctor(inputs)](#M-DigitalLogic16bitComputer-components-gates-AndGate-#ctor-DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.gates.AndGate.#ctor(DigitalLogic16bitComputer.components.NBitArray)')
  - [InputA](#P-DigitalLogic16bitComputer-components-gates-AndGate-InputA 'DigitalLogic16bitComputer.components.gates.AndGate.InputA')
  - [InputB](#P-DigitalLogic16bitComputer-components-gates-AndGate-InputB 'DigitalLogic16bitComputer.components.gates.AndGate.InputB')
  - [Output](#P-DigitalLogic16bitComputer-components-gates-AndGate-Output 'DigitalLogic16bitComputer.components.gates.AndGate.Output')
  - [Dispose()](#M-DigitalLogic16bitComputer-components-gates-AndGate-Dispose 'DigitalLogic16bitComputer.components.gates.AndGate.Dispose')
  - [InitializeInputs(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-AndGate-InitializeInputs-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.AndGate.InitializeInputs(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [Update()](#M-DigitalLogic16bitComputer-components-gates-AndGate-Update 'DigitalLogic16bitComputer.components.gates.AndGate.Update')
- [Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit')
  - [#ctor(value)](#M-DigitalLogic16bitComputer-components-Bit-#ctor-System-Boolean- 'DigitalLogic16bitComputer.components.Bit.#ctor(System.Boolean)')
  - [Value](#P-DigitalLogic16bitComputer-components-Bit-Value 'DigitalLogic16bitComputer.components.Bit.Value')
  - [ConnectFrom(bit)](#M-DigitalLogic16bitComputer-components-Bit-ConnectFrom-DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.Bit.ConnectFrom(DigitalLogic16bitComputer.components.Bit)')
  - [DisconnectFrom(bit)](#M-DigitalLogic16bitComputer-components-Bit-DisconnectFrom-DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.Bit.DisconnectFrom(DigitalLogic16bitComputer.components.Bit)')
  - [Dispose()](#M-DigitalLogic16bitComputer-components-Bit-Dispose 'DigitalLogic16bitComputer.components.Bit.Dispose')
  - [RegisterUpdate(component)](#M-DigitalLogic16bitComputer-components-Bit-RegisterUpdate-DigitalLogic16bitComputer-components-IUpdatable- 'DigitalLogic16bitComputer.components.Bit.RegisterUpdate(DigitalLogic16bitComputer.components.IUpdatable)')
  - [ToString()](#M-DigitalLogic16bitComputer-components-Bit-ToString 'DigitalLogic16bitComputer.components.Bit.ToString')
  - [UnregisterUpdate(component)](#M-DigitalLogic16bitComputer-components-Bit-UnregisterUpdate-DigitalLogic16bitComputer-components-IUpdatable- 'DigitalLogic16bitComputer.components.Bit.UnregisterUpdate(DigitalLogic16bitComputer.components.IUpdatable)')
  - [Update()](#M-DigitalLogic16bitComputer-components-Bit-Update 'DigitalLogic16bitComputer.components.Bit.Update')
- [DFlipFlop](#T-DigitalLogic16bitComputer-components-registers-DFlipFlop 'DigitalLogic16bitComputer.components.registers.DFlipFlop')
  - [#ctor(inputD,inputClk)](#M-DigitalLogic16bitComputer-components-registers-DFlipFlop-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.registers.DFlipFlop.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [Output](#P-DigitalLogic16bitComputer-components-registers-DFlipFlop-Output 'DigitalLogic16bitComputer.components.registers.DFlipFlop.Output')
- [FullAdder](#T-DigitalLogic16bitComputer-components-arithmetic-FullAdder 'DigitalLogic16bitComputer.components.arithmetic.FullAdder')
  - [#ctor(inputA,inputB,inputCarry)](#M-DigitalLogic16bitComputer-components-arithmetic-FullAdder-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.arithmetic.FullAdder.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [InputA](#P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-InputA 'DigitalLogic16bitComputer.components.arithmetic.FullAdder.InputA')
  - [InputB](#P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-InputB 'DigitalLogic16bitComputer.components.arithmetic.FullAdder.InputB')
  - [InputCarry](#P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-InputCarry 'DigitalLogic16bitComputer.components.arithmetic.FullAdder.InputCarry')
  - [Output](#P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-Output 'DigitalLogic16bitComputer.components.arithmetic.FullAdder.Output')
  - [OutputCarry](#P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-OutputCarry 'DigitalLogic16bitComputer.components.arithmetic.FullAdder.OutputCarry')
- [IUpdatable](#T-DigitalLogic16bitComputer-components-IUpdatable 'DigitalLogic16bitComputer.components.IUpdatable')
  - [Update()](#M-DigitalLogic16bitComputer-components-IUpdatable-Update 'DigitalLogic16bitComputer.components.IUpdatable.Update')
- [NBitAdder](#T-DigitalLogic16bitComputer-components-arithmetic-NBitAdder 'DigitalLogic16bitComputer.components.arithmetic.NBitAdder')
  - [#ctor(numA,numB,inputCarry)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.arithmetic.NBitAdder.#ctor(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.Bit)')
  - [OutputCarry](#P-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-OutputCarry 'DigitalLogic16bitComputer.components.arithmetic.NBitAdder.OutputCarry')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitAdder.OutputNum')
  - [OutputOverflow](#P-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-OutputOverflow 'DigitalLogic16bitComputer.components.arithmetic.NBitAdder.OutputOverflow')
- [NBitAdderSubtractor](#T-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor 'DigitalLogic16bitComputer.components.arithmetic.NBitAdderSubtractor')
  - [#ctor(numA,numB,subtract)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.arithmetic.NBitAdderSubtractor.#ctor(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.Bit)')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitAdderSubtractor.OutputNum')
  - [Subtract](#P-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor-Subtract 'DigitalLogic16bitComputer.components.arithmetic.NBitAdderSubtractor.Subtract')
- [NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray')
  - [#ctor(bitArray)](#M-DigitalLogic16bitComputer-components-NBitArray-#ctor-DigitalLogic16bitComputer-components-Bit[]- 'DigitalLogic16bitComputer.components.NBitArray.#ctor(DigitalLogic16bitComputer.components.Bit[])')
  - [Item](#P-DigitalLogic16bitComputer-components-NBitArray-Item-System-Int32- 'DigitalLogic16bitComputer.components.NBitArray.Item(System.Int32)')
  - [Length](#P-DigitalLogic16bitComputer-components-NBitArray-Length 'DigitalLogic16bitComputer.components.NBitArray.Length')
  - [BinaryStringToNBitArray(binaryString)](#M-DigitalLogic16bitComputer-components-NBitArray-BinaryStringToNBitArray-System-String- 'DigitalLogic16bitComputer.components.NBitArray.BinaryStringToNBitArray(System.String)')
  - [GetEnumerator()](#M-DigitalLogic16bitComputer-components-NBitArray-GetEnumerator 'DigitalLogic16bitComputer.components.NBitArray.GetEnumerator')
  - [IntToNBitArray(value,nBits)](#M-DigitalLogic16bitComputer-components-NBitArray-IntToNBitArray-System-Int32,System-Int32- 'DigitalLogic16bitComputer.components.NBitArray.IntToNBitArray(System.Int32,System.Int32)')
  - [SubArray(startIndex,endIndex)](#M-DigitalLogic16bitComputer-components-NBitArray-SubArray-System-Int32,System-Int32- 'DigitalLogic16bitComputer.components.NBitArray.SubArray(System.Int32,System.Int32)')
  - [System#Collections#IEnumerable#GetEnumerator()](#M-DigitalLogic16bitComputer-components-NBitArray-System#Collections#IEnumerable#GetEnumerator 'DigitalLogic16bitComputer.components.NBitArray.System#Collections#IEnumerable#GetEnumerator')
  - [ToBinaryString()](#M-DigitalLogic16bitComputer-components-NBitArray-ToBinaryString 'DigitalLogic16bitComputer.components.NBitArray.ToBinaryString')
  - [ToInt()](#M-DigitalLogic16bitComputer-components-NBitArray-ToInt 'DigitalLogic16bitComputer.components.NBitArray.ToInt')
  - [ToString()](#M-DigitalLogic16bitComputer-components-NBitArray-ToString 'DigitalLogic16bitComputer.components.NBitArray.ToString')
- [NBitDivider](#T-DigitalLogic16bitComputer-components-arithmetic-NBitDivider 'DigitalLogic16bitComputer.components.arithmetic.NBitDivider')
  - [#ctor(numA,numB)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitDivider-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.arithmetic.NBitDivider.#ctor(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.NBitArray)')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitDivider-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitDivider.OutputNum')
  - [OutputRemainder](#P-DigitalLogic16bitComputer-components-arithmetic-NBitDivider-OutputRemainder 'DigitalLogic16bitComputer.components.arithmetic.NBitDivider.OutputRemainder')
- [NBitMultiplier](#T-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier 'DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier')
  - [#ctor(numA,numB)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier.#ctor(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.NBitArray)')
  - [FullOutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-FullOutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier.FullOutputNum')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier.OutputNum')
  - [OutputOverflow](#P-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-OutputOverflow 'DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier.OutputOverflow')
- [NBitPositiveDivider](#T-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveDivider')
  - [#ctor(numA,numB)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveDivider.#ctor(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.NBitArray)')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveDivider.OutputNum')
  - [OutputRemainder](#P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider-OutputRemainder 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveDivider.OutputRemainder')
- [NBitPositiveMultiplier](#T-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier')
  - [#ctor(numA,numB)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.#ctor(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.NBitArray)')
  - [FullOutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-FullOutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.FullOutputNum')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.OutputNum')
  - [OutputOverflow](#P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-OutputOverflow 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.OutputOverflow')
  - [AndAll(num,bit)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-AndAll-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.AndAll(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.Bit)')
  - [ConcatFirst(num,bit)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-ConcatFirst-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.ConcatFirst(DigitalLogic16bitComputer.components.NBitArray,DigitalLogic16bitComputer.components.Bit)')
  - [RemoveLastBit(num)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-RemoveLastBit-DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.arithmetic.NBitPositiveMultiplier.RemoveLastBit(DigitalLogic16bitComputer.components.NBitArray)')
- [NBitTwosComplement](#T-DigitalLogic16bitComputer-components-arithmetic-NBitTwosComplement 'DigitalLogic16bitComputer.components.arithmetic.NBitTwosComplement')
  - [#ctor(number)](#M-DigitalLogic16bitComputer-components-arithmetic-NBitTwosComplement-#ctor-DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.arithmetic.NBitTwosComplement.#ctor(DigitalLogic16bitComputer.components.NBitArray)')
  - [OutputNum](#P-DigitalLogic16bitComputer-components-arithmetic-NBitTwosComplement-OutputNum 'DigitalLogic16bitComputer.components.arithmetic.NBitTwosComplement.OutputNum')
- [NandGate](#T-DigitalLogic16bitComputer-components-gates-NandGate 'DigitalLogic16bitComputer.components.gates.NandGate')
  - [#ctor(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-NandGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.NandGate.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [#ctor(inputs)](#M-DigitalLogic16bitComputer-components-gates-NandGate-#ctor-DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.gates.NandGate.#ctor(DigitalLogic16bitComputer.components.NBitArray)')
  - [Output](#P-DigitalLogic16bitComputer-components-gates-NandGate-Output 'DigitalLogic16bitComputer.components.gates.NandGate.Output')
- [NorGate](#T-DigitalLogic16bitComputer-components-gates-NorGate 'DigitalLogic16bitComputer.components.gates.NorGate')
  - [#ctor(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-NorGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.NorGate.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [#ctor(inputs)](#M-DigitalLogic16bitComputer-components-gates-NorGate-#ctor-DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.gates.NorGate.#ctor(DigitalLogic16bitComputer.components.NBitArray)')
  - [Output](#P-DigitalLogic16bitComputer-components-gates-NorGate-Output 'DigitalLogic16bitComputer.components.gates.NorGate.Output')
- [NotGate](#T-DigitalLogic16bitComputer-components-gates-NotGate 'DigitalLogic16bitComputer.components.gates.NotGate')
  - [#ctor(input)](#M-DigitalLogic16bitComputer-components-gates-NotGate-#ctor-DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.NotGate.#ctor(DigitalLogic16bitComputer.components.Bit)')
  - [Input](#P-DigitalLogic16bitComputer-components-gates-NotGate-Input 'DigitalLogic16bitComputer.components.gates.NotGate.Input')
  - [Output](#P-DigitalLogic16bitComputer-components-gates-NotGate-Output 'DigitalLogic16bitComputer.components.gates.NotGate.Output')
  - [Dispose()](#M-DigitalLogic16bitComputer-components-gates-NotGate-Dispose 'DigitalLogic16bitComputer.components.gates.NotGate.Dispose')
  - [Update()](#M-DigitalLogic16bitComputer-components-gates-NotGate-Update 'DigitalLogic16bitComputer.components.gates.NotGate.Update')
- [OrGate](#T-DigitalLogic16bitComputer-components-gates-OrGate 'DigitalLogic16bitComputer.components.gates.OrGate')
  - [#ctor(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-OrGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.OrGate.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [#ctor(inputs)](#M-DigitalLogic16bitComputer-components-gates-OrGate-#ctor-DigitalLogic16bitComputer-components-NBitArray- 'DigitalLogic16bitComputer.components.gates.OrGate.#ctor(DigitalLogic16bitComputer.components.NBitArray)')
  - [InputA](#P-DigitalLogic16bitComputer-components-gates-OrGate-InputA 'DigitalLogic16bitComputer.components.gates.OrGate.InputA')
  - [InputB](#P-DigitalLogic16bitComputer-components-gates-OrGate-InputB 'DigitalLogic16bitComputer.components.gates.OrGate.InputB')
  - [Output](#P-DigitalLogic16bitComputer-components-gates-OrGate-Output 'DigitalLogic16bitComputer.components.gates.OrGate.Output')
  - [Dispose()](#M-DigitalLogic16bitComputer-components-gates-OrGate-Dispose 'DigitalLogic16bitComputer.components.gates.OrGate.Dispose')
  - [InitializeInputs(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-OrGate-InitializeInputs-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.OrGate.InitializeInputs(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [Update()](#M-DigitalLogic16bitComputer-components-gates-OrGate-Update 'DigitalLogic16bitComputer.components.gates.OrGate.Update')
- [Register](#T-DigitalLogic16bitComputer-components-registers-Register 'DigitalLogic16bitComputer.components.registers.Register')
  - [#ctor(input,clk,enable)](#M-DigitalLogic16bitComputer-components-registers-Register-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.registers.Register.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [inputFlipFlop](#F-DigitalLogic16bitComputer-components-registers-Register-inputFlipFlop 'DigitalLogic16bitComputer.components.registers.Register.inputFlipFlop')
  - [outputFlipFlop](#F-DigitalLogic16bitComputer-components-registers-Register-outputFlipFlop 'DigitalLogic16bitComputer.components.registers.Register.outputFlipFlop')
  - [Input](#P-DigitalLogic16bitComputer-components-registers-Register-Input 'DigitalLogic16bitComputer.components.registers.Register.Input')
  - [Output](#P-DigitalLogic16bitComputer-components-registers-Register-Output 'DigitalLogic16bitComputer.components.registers.Register.Output')
- [SRLatch](#T-DigitalLogic16bitComputer-components-registers-SRLatch 'DigitalLogic16bitComputer.components.registers.SRLatch')
  - [#ctor(inputS,inputR)](#M-DigitalLogic16bitComputer-components-registers-SRLatch-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.registers.SRLatch.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [InputR](#P-DigitalLogic16bitComputer-components-registers-SRLatch-InputR 'DigitalLogic16bitComputer.components.registers.SRLatch.InputR')
  - [InputS](#P-DigitalLogic16bitComputer-components-registers-SRLatch-InputS 'DigitalLogic16bitComputer.components.registers.SRLatch.InputS')
  - [OutputQ](#P-DigitalLogic16bitComputer-components-registers-SRLatch-OutputQ 'DigitalLogic16bitComputer.components.registers.SRLatch.OutputQ')
  - [OutputQPrime](#P-DigitalLogic16bitComputer-components-registers-SRLatch-OutputQPrime 'DigitalLogic16bitComputer.components.registers.SRLatch.OutputQPrime')
  - [Dispose()](#M-DigitalLogic16bitComputer-components-registers-SRLatch-Dispose 'DigitalLogic16bitComputer.components.registers.SRLatch.Dispose')
  - [Update()](#M-DigitalLogic16bitComputer-components-registers-SRLatch-Update 'DigitalLogic16bitComputer.components.registers.SRLatch.Update')
- [XorGate](#T-DigitalLogic16bitComputer-components-gates-XorGate 'DigitalLogic16bitComputer.components.gates.XorGate')
  - [#ctor(inputA,inputB)](#M-DigitalLogic16bitComputer-components-gates-XorGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit- 'DigitalLogic16bitComputer.components.gates.XorGate.#ctor(DigitalLogic16bitComputer.components.Bit,DigitalLogic16bitComputer.components.Bit)')
  - [Output](#P-DigitalLogic16bitComputer-components-gates-XorGate-Output 'DigitalLogic16bitComputer.components.gates.XorGate.Output')

<a name='T-DigitalLogic16bitComputer-components-gates-AndGate'></a>
## AndGate `type`

##### Namespace

DigitalLogic16bitComputer.components.gates

##### Summary

Represents an AND gate in a digital logic circuit.

<a name='M-DigitalLogic16bitComputer-components-gates-AndGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputA,inputB) `constructor`

##### Summary

Initializes a new instance of the AndGate class with two input bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The first input bit |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The second input bit |

<a name='M-DigitalLogic16bitComputer-components-gates-AndGate-#ctor-DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(inputs) `constructor`

##### Summary

Initializes a new instance of the AndGate class with an array of input bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputs | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | An array of input bits |

<a name='P-DigitalLogic16bitComputer-components-gates-AndGate-InputA'></a>
### InputA `property`

##### Summary

The first input bit for the AND gate

<a name='P-DigitalLogic16bitComputer-components-gates-AndGate-InputB'></a>
### InputB `property`

##### Summary

The second input bit for the AND gate

<a name='P-DigitalLogic16bitComputer-components-gates-AndGate-Output'></a>
### Output `property`

##### Summary

The output bit for the AND gate

<a name='M-DigitalLogic16bitComputer-components-gates-AndGate-Dispose'></a>
### Dispose() `method`

##### Summary

Unregisters the update for the inputs

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-gates-AndGate-InitializeInputs-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### InitializeInputs(inputA,inputB) `method`

##### Summary

Initializes the inputs and output of the AND gate

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The first input |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The second input |

<a name='M-DigitalLogic16bitComputer-components-gates-AndGate-Update'></a>
### Update() `method`

##### Summary

Updates the output of the AND gate based on the inputs

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-Bit'></a>
## Bit `type`

##### Namespace

DigitalLogic16bitComputer.components

##### Summary

Represents a single bit in a digital logic circuit.

<a name='M-DigitalLogic16bitComputer-components-Bit-#ctor-System-Boolean-'></a>
### #ctor(value) `constructor`

##### Summary

Initializes a new instance of the Bit class with an optional initial value

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The initial value of the bit (default is false) |

<a name='P-DigitalLogic16bitComputer-components-Bit-Value'></a>
### Value `property`

##### Summary

Gets or sets the value of the bit (either true or false)

<a name='M-DigitalLogic16bitComputer-components-Bit-ConnectFrom-DigitalLogic16bitComputer-components-Bit-'></a>
### ConnectFrom(bit) `method`

##### Summary

Connects this bit to another bit

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bit | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The bit to be connected to |

<a name='M-DigitalLogic16bitComputer-components-Bit-DisconnectFrom-DigitalLogic16bitComputer-components-Bit-'></a>
### DisconnectFrom(bit) `method`

##### Summary

Disconnects this bit from another bit

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bit | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The bit to be disconnected from |

<a name='M-DigitalLogic16bitComputer-components-Bit-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes of this bit and its connections

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-Bit-RegisterUpdate-DigitalLogic16bitComputer-components-IUpdatable-'></a>
### RegisterUpdate(component) `method`

##### Summary

Registers a component to be updated when the value of this bit changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| component | [DigitalLogic16bitComputer.components.IUpdatable](#T-DigitalLogic16bitComputer-components-IUpdatable 'DigitalLogic16bitComputer.components.IUpdatable') | The component to be updated |

<a name='M-DigitalLogic16bitComputer-components-Bit-ToString'></a>
### ToString() `method`

##### Summary

Converts the value of this bit to a string representation

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-Bit-UnregisterUpdate-DigitalLogic16bitComputer-components-IUpdatable-'></a>
### UnregisterUpdate(component) `method`

##### Summary

Unregisters a component from being updated when the value of this bit changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| component | [DigitalLogic16bitComputer.components.IUpdatable](#T-DigitalLogic16bitComputer-components-IUpdatable 'DigitalLogic16bitComputer.components.IUpdatable') | The component to be removed |

<a name='M-DigitalLogic16bitComputer-components-Bit-Update'></a>
### Update() `method`

##### Summary

Updates the value of this bit based on its connections

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-registers-DFlipFlop'></a>
## DFlipFlop `type`

##### Namespace

DigitalLogic16bitComputer.components.registers

##### Summary

A D Flip-Flop is a type of bistable latch that has two stable states, one of which is the set state and the other is the reset state.
The output of the flip-flop is the stored state which can be set or reset by the input D and the input Clock.

<a name='M-DigitalLogic16bitComputer-components-registers-DFlipFlop-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputD,inputClk) `constructor`

##### Summary

Constructs a D Flip-Flop with input D and input Clock

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputD | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The input to set or reset the stored state |
| inputClk | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The input to control when to set or reset the stored state |

<a name='P-DigitalLogic16bitComputer-components-registers-DFlipFlop-Output'></a>
### Output `property`

##### Summary

The output of the D Flip-Flop. This is the stored state.

<a name='T-DigitalLogic16bitComputer-components-arithmetic-FullAdder'></a>
## FullAdder `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

A full adder is a digital circuit that performs the arithmetic operation of addition, specifically, 
the addition of two binary digits and a carry.

<a name='M-DigitalLogic16bitComputer-components-arithmetic-FullAdder-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputA,inputB,inputCarry) `constructor`

##### Summary

Constructs a FullAdder object with input bits and carry.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | First input bit to be added |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | Second input bit to be added |
| inputCarry | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | Carry input from a previous addition |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-InputA'></a>
### InputA `property`

##### Summary

First input bit to be added

<a name='P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-InputB'></a>
### InputB `property`

##### Summary

Second input bit to be added

<a name='P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-InputCarry'></a>
### InputCarry `property`

##### Summary

Carry input from a previous addition

<a name='P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-Output'></a>
### Output `property`

##### Summary

Output of the addition of the three input bits

<a name='P-DigitalLogic16bitComputer-components-arithmetic-FullAdder-OutputCarry'></a>
### OutputCarry `property`

##### Summary

Carry output for the next addition

<a name='T-DigitalLogic16bitComputer-components-IUpdatable'></a>
## IUpdatable `type`

##### Namespace

DigitalLogic16bitComputer.components

##### Summary

Interface for updatable components

<a name='M-DigitalLogic16bitComputer-components-IUpdatable-Update'></a>
### Update() `method`

##### Summary

Update the component's state

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitAdder'></a>
## NBitAdder `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

A class that represents a N-Bit Adder, which takes in two N-bit numbers and an input carry
and outputs the sum of the two numbers, the carry out, and the overflow bit.

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(numA,numB,inputCarry) `constructor`

##### Summary

Constructs an NBitAdder, which takes in two N-bit numbers and an input carry
and outputs the sum of the two numbers, the carry out, and the overflow bit.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The first N-bit number to be added |
| numB | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The second N-bit number to be added |
| inputCarry | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The input carry bit, indicating whether a carry is being propagated from a previous addition |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-OutputCarry'></a>
### OutputCarry `property`

##### Summary

The carry out bit of the addition, indicating whether a carry occurred from the most significant bit

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-OutputNum'></a>
### OutputNum `property`

##### Summary

The resulting sum of the two input numbers, in the form of an [NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray')

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitAdder-OutputOverflow'></a>
### OutputOverflow `property`

##### Summary

The overflow bit of the addition, indicating whether an overflow occurred from the addition

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor'></a>
## NBitAdderSubtractor `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

Represents a N-bit adder-subtractor circuit.

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(numA,numB,subtract) `constructor`

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The first N-bit number to be added or subtracted. |
| numB | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The second N-bit number to be added or subtracted. |
| subtract | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | A bit that determines whether the operation is addition or subtraction. |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor-OutputNum'></a>
### OutputNum `property`

##### Summary

The N-bit output of the circuit.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitAdderSubtractor-Subtract'></a>
### Subtract `property`

##### Summary

Indicates whether the circuit is in subtraction mode.

<a name='T-DigitalLogic16bitComputer-components-NBitArray'></a>
## NBitArray `type`

##### Namespace

DigitalLogic16bitComputer.components

##### Summary

Wrapper for an array of bits with a few utility functions

<a name='M-DigitalLogic16bitComputer-components-NBitArray-#ctor-DigitalLogic16bitComputer-components-Bit[]-'></a>
### #ctor(bitArray) `constructor`

##### Summary

Initializes a new instance of the NBitArray class with a given array of bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bitArray | [DigitalLogic16bitComputer.components.Bit[]](#T-DigitalLogic16bitComputer-components-Bit[] 'DigitalLogic16bitComputer.components.Bit[]') | The array of bits to be wrapped |

<a name='P-DigitalLogic16bitComputer-components-NBitArray-Item-System-Int32-'></a>
### Item `property`

##### Summary

Indexer for accessing individual bits in the array

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| i | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the desired bit |

<a name='P-DigitalLogic16bitComputer-components-NBitArray-Length'></a>
### Length `property`

##### Summary

The number of bits in the array

<a name='M-DigitalLogic16bitComputer-components-NBitArray-BinaryStringToNBitArray-System-String-'></a>
### BinaryStringToNBitArray(binaryString) `method`

##### Summary

Converts a binary string to a NBitArray

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| binaryString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The binary string to be converted |

<a name='M-DigitalLogic16bitComputer-components-NBitArray-GetEnumerator'></a>
### GetEnumerator() `method`

##### Summary

Gets an enumerator for the bits in the array

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-NBitArray-IntToNBitArray-System-Int32,System-Int32-'></a>
### IntToNBitArray(value,nBits) `method`

##### Summary

Converts an integer to a NBitArray

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The integer to be converted |
| nBits | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number of bits in the resulting NBitArray |

<a name='M-DigitalLogic16bitComputer-components-NBitArray-SubArray-System-Int32,System-Int32-'></a>
### SubArray(startIndex,endIndex) `method`

##### Summary

Creates a sub array of this NBitArray

##### Returns

A sub array of this NBitArray

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The first bit index to be included |
| endIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The last bit index to be included |

<a name='M-DigitalLogic16bitComputer-components-NBitArray-System#Collections#IEnumerable#GetEnumerator'></a>
### System#Collections#IEnumerable#GetEnumerator() `method`

##### Summary

Gets an enumerator for the bits in the array

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-NBitArray-ToBinaryString'></a>
### ToBinaryString() `method`

##### Summary

Converts the bit array to a binary string

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-NBitArray-ToInt'></a>
### ToInt() `method`

##### Summary

Converts the bit array to an integer

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-NBitArray-ToString'></a>
### ToString() `method`

##### Summary

Converts the bit array to a string representation

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitDivider'></a>
## NBitDivider `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

Division module for two N-bit integers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [T:DigitalLogic16bitComputer.components.arithmetic.NBitDivider](#T-T-DigitalLogic16bitComputer-components-arithmetic-NBitDivider 'T:DigitalLogic16bitComputer.components.arithmetic.NBitDivider') | Number A |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Both numbers must have at least 3 bits each and be of the same length |

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitDivider-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(numA,numB) `constructor`

##### Summary

Division module for two N-bit integers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number A |
| numB | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number B |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Both numbers must have at least 3 bits each and be of the same length |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitDivider-OutputNum'></a>
### OutputNum `property`

##### Summary

The result of the devision.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitDivider-OutputRemainder'></a>
### OutputRemainder `property`

##### Summary

The remainder of the division.

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier'></a>
## NBitMultiplier `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

Multiplication module for two N-bit integers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [T:DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier](#T-T-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier 'T:DigitalLogic16bitComputer.components.arithmetic.NBitMultiplier') | Number A |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Both numbers must have at least 3 bits each and be of the same length |

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(numA,numB) `constructor`

##### Summary

Multiplication module for two N-bit integers.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number A |
| numB | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number B |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Both numbers must have at least 3 bits each and be of the same length |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-FullOutputNum'></a>
### FullOutputNum `property`

##### Summary

The resulting product of the multiplication in full 2's complement representation.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-OutputNum'></a>
### OutputNum `property`

##### Summary

The N first bits of the resulting product of the multiplication in 2's complement representation.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitMultiplier-OutputOverflow'></a>
### OutputOverflow `property`

##### Summary

The overflow bit indicating if the result of the multiplication exceeds the range of an N-bit number.

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider'></a>
## NBitPositiveDivider `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(numA,numB) `constructor`

##### Summary

Division module for two N-bit POSITIVE integers. This module does not work if negative numbers are passed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number A |
| numB | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number B |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Both numbers must have at least 3 bits each and be of the same length |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider-OutputNum'></a>
### OutputNum `property`

##### Summary

The result of the devision.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveDivider-OutputRemainder'></a>
### OutputRemainder `property`

##### Summary

The remainder of the division.

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier'></a>
## NBitPositiveMultiplier `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

Represents a N-bit multiplier circuit for positive integers.

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-#ctor-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(numA,numB) `constructor`

##### Summary

Multiplication module for two N-bit POSITIVE integers. This module does not work if negative numbers are passed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| numA | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number A |
| numB | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | Number B |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Both numbers must have at least 3 bits each and be of the same length |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-FullOutputNum'></a>
### FullOutputNum `property`

##### Summary

The resulting product of the multiplication in full 2's complement representation.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-OutputNum'></a>
### OutputNum `property`

##### Summary

The N first bits of the resulting product of the multiplication in 2's complement representation.

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-OutputOverflow'></a>
### OutputOverflow `property`

##### Summary

Represents the overflow bit of the multiplication operation.

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-AndAll-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit-'></a>
### AndAll(num,bit) `method`

##### Summary

Perform bitwise AND operation on all bits of `num` using `bit`

##### Returns

The NBitArray with the result of the operation

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The NBitArray to perform the operation on |
| bit | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The Bit to compare with |

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-ConcatFirst-DigitalLogic16bitComputer-components-NBitArray,DigitalLogic16bitComputer-components-Bit-'></a>
### ConcatFirst(num,bit) `method`

##### Summary

Create a new NBitArray by concatenating `bit` at the beginning of `num`

##### Returns

The new NBitArray

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The NBitArray to append to |
| bit | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The Bit to append |

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitPositiveMultiplier-RemoveLastBit-DigitalLogic16bitComputer-components-NBitArray-'></a>
### RemoveLastBit(num) `method`

##### Summary

Remove the last bit of `num`

##### Returns

The NBitArray with the last bit removed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| num | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The NBitArray to remove the last bit from |

<a name='T-DigitalLogic16bitComputer-components-arithmetic-NBitTwosComplement'></a>
## NBitTwosComplement `type`

##### Namespace

DigitalLogic16bitComputer.components.arithmetic

##### Summary

Class for creating the two's complement representation of a number.

<a name='M-DigitalLogic16bitComputer-components-arithmetic-NBitTwosComplement-#ctor-DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(number) `constructor`

##### Summary

Creates a new instance of the class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| number | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The input number to convert to two's complement |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown when the number of bits in the input number is less than 2 |

<a name='P-DigitalLogic16bitComputer-components-arithmetic-NBitTwosComplement-OutputNum'></a>
### OutputNum `property`

##### Summary

The two's complement of the input number

<a name='T-DigitalLogic16bitComputer-components-gates-NandGate'></a>
## NandGate `type`

##### Namespace

DigitalLogic16bitComputer.components.gates

##### Summary

A logical NAND gate implementation

<a name='M-DigitalLogic16bitComputer-components-gates-NandGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputA,inputB) `constructor`

##### Summary

Initializes a new instance of the NandGate class with two input bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The first input bit |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The second input bit |

<a name='M-DigitalLogic16bitComputer-components-gates-NandGate-#ctor-DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(inputs) `constructor`

##### Summary

Initializes a new instance of the NandGate class with an NBitArray of inputs

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputs | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The NBitArray of inputs |

<a name='P-DigitalLogic16bitComputer-components-gates-NandGate-Output'></a>
### Output `property`

##### Summary

The output of the NAND gate

<a name='T-DigitalLogic16bitComputer-components-gates-NorGate'></a>
## NorGate `type`

##### Namespace

DigitalLogic16bitComputer.components.gates

##### Summary

A logical NOR gate implementation

<a name='M-DigitalLogic16bitComputer-components-gates-NorGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputA,inputB) `constructor`

##### Summary

Initializes a new instance of the NorGate class with two input bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The first input bit |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The second input bit |

<a name='M-DigitalLogic16bitComputer-components-gates-NorGate-#ctor-DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(inputs) `constructor`

##### Summary

Initializes a new instance of the NorGate class with an NBitArray of inputs

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputs | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The NBitArray of inputs |

<a name='P-DigitalLogic16bitComputer-components-gates-NorGate-Output'></a>
### Output `property`

##### Summary

The output of the Nor gate

<a name='T-DigitalLogic16bitComputer-components-gates-NotGate'></a>
## NotGate `type`

##### Namespace

DigitalLogic16bitComputer.components.gates

##### Summary

Represents a NOT gate in a digital logic circuit.

<a name='M-DigitalLogic16bitComputer-components-gates-NotGate-#ctor-DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(input) `constructor`

##### Summary

Initializes a new instance of the NotGate class

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The input bit for the NOT gate |

<a name='P-DigitalLogic16bitComputer-components-gates-NotGate-Input'></a>
### Input `property`

##### Summary

The input bit for the NOT gate

<a name='P-DigitalLogic16bitComputer-components-gates-NotGate-Output'></a>
### Output `property`

##### Summary

The output bit for the NOT gate

<a name='M-DigitalLogic16bitComputer-components-gates-NotGate-Dispose'></a>
### Dispose() `method`

##### Summary

Unregisters the component from the input bit

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-gates-NotGate-Update'></a>
### Update() `method`

##### Summary

Updates the output bit based on the input bit

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-gates-OrGate'></a>
## OrGate `type`

##### Namespace

DigitalLogic16bitComputer.components.gates

##### Summary

Represents an OR gate in a digital logic circuit.

<a name='M-DigitalLogic16bitComputer-components-gates-OrGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputA,inputB) `constructor`

##### Summary

Initializes a new instance of the OrGate class with two input bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The first input bit for the OR gate |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The second input bit for the OR gate |

<a name='M-DigitalLogic16bitComputer-components-gates-OrGate-#ctor-DigitalLogic16bitComputer-components-NBitArray-'></a>
### #ctor(inputs) `constructor`

##### Summary

Initializes a new instance of the OrGate class with N input bits

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputs | [DigitalLogic16bitComputer.components.NBitArray](#T-DigitalLogic16bitComputer-components-NBitArray 'DigitalLogic16bitComputer.components.NBitArray') | The input bits for the OR gate |

<a name='P-DigitalLogic16bitComputer-components-gates-OrGate-InputA'></a>
### InputA `property`

##### Summary

The first input bit for the OR gate

<a name='P-DigitalLogic16bitComputer-components-gates-OrGate-InputB'></a>
### InputB `property`

##### Summary

The second input bit for the OR gate

<a name='P-DigitalLogic16bitComputer-components-gates-OrGate-Output'></a>
### Output `property`

##### Summary

The output bit for the OR gate

<a name='M-DigitalLogic16bitComputer-components-gates-OrGate-Dispose'></a>
### Dispose() `method`

##### Summary

Unregisters the update for the inputs

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-gates-OrGate-InitializeInputs-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### InitializeInputs(inputA,inputB) `method`

##### Summary

Initializes the inputs and output of the OR gate

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The first input |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The second input |

<a name='M-DigitalLogic16bitComputer-components-gates-OrGate-Update'></a>
### Update() `method`

##### Summary

Updates the output of the AND gate based on the inputs

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-registers-Register'></a>
## Register `type`

##### Namespace

DigitalLogic16bitComputer.components.registers

##### Summary

A class that represents a register that stores a single bit.

<a name='M-DigitalLogic16bitComputer-components-registers-Register-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(input,clk,enable) `constructor`

##### Summary

Initializes a new instance of the [Register](#T-DigitalLogic16bitComputer-components-registers-Register 'DigitalLogic16bitComputer.components.registers.Register') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The input bit for the register. |
| clk | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The clock input for the register. |
| enable | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The enable input for the register. |

<a name='F-DigitalLogic16bitComputer-components-registers-Register-inputFlipFlop'></a>
### inputFlipFlop `constants`

##### Summary

A D-flip-flop that serves as the input for the register.

<a name='F-DigitalLogic16bitComputer-components-registers-Register-outputFlipFlop'></a>
### outputFlipFlop `constants`

##### Summary

A D-flip-flop that serves as the output for the register.

<a name='P-DigitalLogic16bitComputer-components-registers-Register-Input'></a>
### Input `property`

##### Summary

The input bit for the register.

<a name='P-DigitalLogic16bitComputer-components-registers-Register-Output'></a>
### Output `property`

##### Summary

The output bit for the register.

<a name='T-DigitalLogic16bitComputer-components-registers-SRLatch'></a>
## SRLatch `type`

##### Namespace

DigitalLogic16bitComputer.components.registers

##### Summary

SR Latch is a fundamental building block of many sequential logic circuits.
It is a bistable circuit that has two stable states, and can be used to store a bit of information.
The circuit has two inputs, S (set) and R (reset), and two outputs, Q and Q' (Q prime).
When S is true and R is false, the circuit's output will be Q = 1, Q' = 0.
When S is false and R is true, the circuit's output will be Q = 0, Q' = 1.
If both S and R are true, the circuit is in an invalid state.

<a name='M-DigitalLogic16bitComputer-components-registers-SRLatch-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputS,inputR) `constructor`

##### Summary

Initializes a new SR Latch with the provided input S and input R

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputS | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The S input |
| inputR | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | The R input |

<a name='P-DigitalLogic16bitComputer-components-registers-SRLatch-InputR'></a>
### InputR `property`

##### Summary

The R input

<a name='P-DigitalLogic16bitComputer-components-registers-SRLatch-InputS'></a>
### InputS `property`

##### Summary

The S input

<a name='P-DigitalLogic16bitComputer-components-registers-SRLatch-OutputQ'></a>
### OutputQ `property`

##### Summary

The Q output

<a name='P-DigitalLogic16bitComputer-components-registers-SRLatch-OutputQPrime'></a>
### OutputQPrime `property`

##### Summary

The Q' output

<a name='M-DigitalLogic16bitComputer-components-registers-SRLatch-Dispose'></a>
### Dispose() `method`

##### Summary

Disposes of the SR Latch

##### Parameters

This method has no parameters.

<a name='M-DigitalLogic16bitComputer-components-registers-SRLatch-Update'></a>
### Update() `method`

##### Summary

Updates the circuit's output based on the inputs

##### Parameters

This method has no parameters.

<a name='T-DigitalLogic16bitComputer-components-gates-XorGate'></a>
## XorGate `type`

##### Namespace

DigitalLogic16bitComputer.components.gates

##### Summary

A XOR gate implementation

<a name='M-DigitalLogic16bitComputer-components-gates-XorGate-#ctor-DigitalLogic16bitComputer-components-Bit,DigitalLogic16bitComputer-components-Bit-'></a>
### #ctor(inputA,inputB) `constructor`

##### Summary

Initializes a new instance of the [XorGate](#T-DigitalLogic16bitComputer-components-gates-XorGate 'DigitalLogic16bitComputer.components.gates.XorGate') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputA | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | First input for the XOR gate |
| inputB | [DigitalLogic16bitComputer.components.Bit](#T-DigitalLogic16bitComputer-components-Bit 'DigitalLogic16bitComputer.components.Bit') | Second input for the XOR gate |

<a name='P-DigitalLogic16bitComputer-components-gates-XorGate-Output'></a>
### Output `property`

##### Summary

Output bit of the XOR gate
