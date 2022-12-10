using System;
using System.Collections.Generic;
using System.Linq;
using AmongUs.GameOptions;


namespace TownOfHost
{
    public abstract class OptionBackupValue
    {
        public abstract void Restore(IGameOptions option);
    }

    public abstract class OptionBackupValueBase<NameT, ValueT> : OptionBackupValue
    where NameT : Enum
    {
        public readonly NameT OptionName;
        public readonly ValueT Value;
        public OptionBackupValueBase(NameT name, ValueT value)
        {
            OptionName = name;
            Value = value;
        }
    }

    public class ByteOptionBackupValue : OptionBackupValueBase<ByteOptionNames, byte>
    {
        public ByteOptionBackupValue(ByteOptionNames name, byte value) : base(name, value) { }
        public override void Restore(IGameOptions option)
        {
            throw new NotImplementedException();
        }
    }
    public class BoolOptionBackupValue : OptionBackupValueBase<BoolOptionNames, bool>
    {
        public BoolOptionBackupValue(BoolOptionNames name, bool value) : base(name, value) { }
        public override void Restore(IGameOptions option)
        {
            throw new NotImplementedException();
        }
    }
    public class FloatOptionBackupValue : OptionBackupValueBase<FloatOptionNames, float>
    {
        public FloatOptionBackupValue(FloatOptionNames name, float value) : base(name, value) { }
        public override void Restore(IGameOptions option)
        {
            throw new NotImplementedException();
        }
    }
    public class IntOptionBackupValue : OptionBackupValueBase<Int32OptionNames, int>
    {
        public IntOptionBackupValue(Int32OptionNames name, int value) : base(name, value) { }
        public override void Restore(IGameOptions option)
        {
            throw new NotImplementedException();
        }
    }
    public class IntArrayOptionBackupValue : OptionBackupValueBase<Int32ArrayOptionNames, int[]>
    {
        public IntArrayOptionBackupValue(Int32ArrayOptionNames name, int[] value) : base(name, value) { }
        public override void Restore(IGameOptions option)
        {
            throw new NotImplementedException();
        }
    }
    public class FloatArrayOptionBackupValue : OptionBackupValueBase<FloatArrayOptionNames, float[]>
    {
        public FloatArrayOptionBackupValue(FloatArrayOptionNames name, float[] value) : base(name, value) { }
        public override void Restore(IGameOptions option)
        {
            throw new NotImplementedException();
        }
    }
}