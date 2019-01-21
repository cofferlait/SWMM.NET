using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing.Design;

namespace SWMM.Components
{
    [Editor(typeof(Design.ActionCollectionEditor), typeof(UITypeEditor))]
    public class TActionCollection: Collection<TAction>
    {
        public TActionCollection(TActionList parent)
        {
            this.parent = parent;
        }

        private TActionList parent;
        public TActionList Parent
        {
            get { return parent; }
        }

        protected override void ClearItems()
        {
            foreach (TAction action in this)
                action.ActionList = null;

            base.ClearItems();
        }

        protected override void InsertItem(int index, TAction item)
        {
            base.InsertItem(index, item);
            item.ActionList = Parent;
        }

        protected override void RemoveItem(int index)
        {
            this[index].ActionList = null;
            base.RemoveItem(index);
        }

        protected override void SetItem(int index, TAction item)
        {
            if (this.Count > index)
                this[index].ActionList = null;
            base.SetItem(index, item);

            item.ActionList = Parent;
        }
    }
}
