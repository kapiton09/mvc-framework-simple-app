using System;
using System.Collections;

namespace Assignment_1B
{
    public interface IPersonView
    {
        void RefreshView();
    }

    /// <summary>
    /// Summary description for PersonsController.
    /// </summary>
    public class PersonsController
    {
        private ArrayList ViewList;

        // constructor
        public PersonsController()
        {
            ViewList = new ArrayList();
        }

        /// <summary>method: AddView
		/// add view to viewlist
		/// </summary>
		/// <param name="aView"></param>
		public void AddView(IPersonView aView)
        {
            ViewList.Add(aView);
        }

        /// <summary>method: UpdateViews
		/// update each view 
		/// </summary>
		public void UpdateViews()
        {
            IPersonView[] theViews = (IPersonView[])ViewList.ToArray(typeof(IPersonView));
            foreach (IPersonView v in theViews)
            {
                v.RefreshView();
            }
        }
    }
}
