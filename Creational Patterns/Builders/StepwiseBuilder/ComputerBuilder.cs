using StepwiseBuilder.Contracts;
using StepwiseBuilder.ProductToBuild;

namespace StepwiseBuilder.Builder;

public class ComputerBuilder
{
    public static ICPUBuilder Create()
    {
        return new Impl();
    }
    private class Impl :
        ICPUBuilder,
        IGPUBuilder,
        IRAMBuilder,
        ISSDBuilder,
        IBuildCar
    {
        private Computer _computer = new();
        public Computer Build()
        {
            return _computer;
        }

        public IGPUBuilder SetCPU(string cpu)
        {
            _computer.CPU = cpu;
            return this;
        }

        public IRAMBuilder SetGPU(string gpu)
        {
            _computer.GPU = gpu;
            return this;
        }

        public ISSDBuilder SetRAM(string ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public IBuildCar SetSSD(string ssd)
        {
            _computer.SSD = ssd;
            return this;
        }
    }
}