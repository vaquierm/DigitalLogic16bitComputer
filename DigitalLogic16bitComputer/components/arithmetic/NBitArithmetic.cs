using DigitalLogic16bitComputer.components.arithmetic.shift;
using DigitalLogic16bitComputer.components.arithmetic.logic;
using DigitalLogic16bitComputer.components.control;

namespace DigitalLogic16bitComputer.components.arithmetic
{
    /// <summary>
    /// The N-bit Arithmetic class performs various arithmetic and logic operations on two N-bit numbers.
    /// </summary>
    public class NBitArithmetic
    {
        /// <summary>
        /// The N-bit output of the circuit.
        /// </summary>
        public NBitArray OutputNum { get; }

        /// <summary>
        /// The constructor of the NBitArithmetic class.
        /// 1: ADD
        /// 2: SUB
        /// 3: DIV
        /// 4: MOD
        /// 5: MUL
        /// 6: NOT
        /// 7: AND
        /// 8: ORR
        /// 9: XOR
        /// 10: ORN
        /// 11: BIC
        /// 12: RSB (NEG)
        /// 13: LSL
        /// 14: LSR
        /// 15: ROR
        /// 16: ASR
        /// </summary>
        /// <param name="inputA">The first operand of the operation as an NBitArray.</param>
        /// <param name="inputB">The second operand of the operation as an NBitArray.</param>
        /// <param name="opSelect1">The first control bit that determines the operation to be performed.</param>
        /// <param name="opSelect2">The second control bit that determines the operation to be performed.</param>
        /// <param name="opSelect3">The third control bit that determines the operation to be performed.</param>
        /// <param name="opSelect4">The fourth control bit that determines the operation to be performed.</param>
        public NBitArithmetic(NBitArray inputA, NBitArray inputB, Bit opSelect1, Bit opSelect2, Bit opSelect3, Bit opSelect4)
		{
            

            var adderSubtractor = new NBitAdderSubtractor(inputA, inputB, opSelect4);
			var multiplier = new NBitMultiplier(inputA, inputB);
			var divider = new NBitDivider(inputA, inputB);
			var bitwiseNot = new NBitBitwiseNot(inputA);
			var bitwiseAnd = new NBitBitwiseAnd(inputA, inputB);
			var bitwiseOr = new NBitBitwiseOr(inputA, inputB);
			var bitwiseXor = new NBitBitwiseXor(inputA, inputB);
			var bitwiseNor = new NBitBitwiseNor(inputA, inputB);
			var bitwiseNand = new NBitBitwiseNand(inputA, inputB);
            var shifter = new NBitShift(inputA, inputB, opSelect3, opSelect4);
			var negate = new NBitAdderSubtractor(NBitArray.IntToNBitArray(0, inputA.Length), inputA, new Bit(true));
			var muxInputs = new NBitArray[]
			{
                adderSubtractor.OutputNum,
                adderSubtractor.OutputNum,
                divider.OutputNum,
                divider.OutputRemainder,
                multiplier.OutputNum,
                bitwiseNot.OutputNum,
                bitwiseAnd.OutputNum,
                bitwiseOr.OutputNum,
                bitwiseXor.OutputNum,
                bitwiseNor.OutputNum,
                bitwiseNand.OutputNum,
                negate.OutputNum,
                shifter.OutputNum,
                shifter.OutputNum,
                shifter.OutputNum,
                shifter.OutputNum,
            };
            var outputMux = new NBitMultiplexer(muxInputs, new NBitArray(new Bit[] { opSelect1, opSelect2, opSelect3, opSelect4 }));
            this.OutputNum = outputMux.NBitOutput;
        }
    }
}
