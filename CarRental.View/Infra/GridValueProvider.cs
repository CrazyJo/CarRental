using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            DomainModelEmpty = true;
            DataGridView = dataGridView;
            ExcludeColumns = new List<string>();
        }

        public virtual async Task SetData()
        {
            IEnumerable<TDomainModel> domainModel = await GetDomainModel();
            if (domainModel != null)
            {
                DomainModelEmpty = !domainModel.Any();
            }
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

        protected abstract Task<IEnumerable<TDomainModel>> GetDomainModel();

        private void SetDefaultGridData()
        {
            GridDataSource = Enumerable.Empty<object>();
        }
    }
}
