using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarRental.View.Infra
{
    public abstract class GridValueProvider<TDomainModel, TViewModel>
    {
        public object GridDataSource
        {
            get { return DataGridView.DataSource; }
            set { DataGridView.DataSource = value; }
        }

        public bool DomainModelEmpty { get; set; }
        public DataGridView DataGridView { get; set; }
        public List<string> ExcludeColumns { get; set; }

        protected GridValueProvider(DataGridView dataGridView)
        {
            DataGridView = dataGridView;
            ExcludeColumns = new List<string>();
        }

        public void SetData()
        {
            IEnumerable<TDomainModel> domainModel = GetDomainModel();
            DomainModelEmpty = !domainModel.Any();
            if (DomainModelEmpty)
            {
                SetDefaultGridData();
            }
            else
            {
                IEnumerable<TViewModel> viewModel = Convert(domainModel);
                GridDataSource = viewModel;
                Format();
            }
        }

        protected virtual void Format()
        {
            foreach (var excludeColumn in ExcludeColumns)
            {
                var column = DataGridView.Columns[excludeColumn];
                if (column != null) column.Visible = false;
            }
        }

        protected abstract IEnumerable<TViewModel> Convert(IEnumerable<TDomainModel> domainModel);

        protected abstract IEnumerable<TDomainModel> GetDomainModel();

        private void SetDefaultGridData()
        {
            GridDataSource = Enumerable.Empty<object>();
        }
    }
}
