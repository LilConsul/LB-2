using System;

namespace LB_2 {
    public class CopyBook {
        public string Name { get; }
        public uint Pages { get; }
        
        public CopyBook(string name, uint pages) {
            if (pages <= 0)
                throw new Exception("Замала к-сть сторінок!");
            Name = name;
            Pages = pages;
        }
        
        public virtual uint Price() => 15 * Pages;
        
    }

    public class SuperBook : CopyBook {
        public SuperBook(string name, uint pages) : base(name, pages) { }

        public override uint Price() => 50 + 15 * Pages;
    }
}