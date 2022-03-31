namespace Hard_As_Concrete;

public partial class concreteCalculator : Form
{
    public concreteCalculator()
    {
        InitializeComponent();
    }
    
    private void calculateButton_Click(object sender, EventArgs e)
    {
        try
        {
            //The depth of every driveway.
            const double DRIVEWAY_DEPTH = 0.5;
            //Amount of concrete created from 1 kg of cement
            const double CONCRETE_PER_KG = 1.5;
            //Weight of a bag of cement
            const double BAG_WEIGHT = 2.0;
            //Cost of a bag of cement
            const decimal BAG_COST = 15.5m;
            //declare variables
            double drivewayLength = 0;
            double drivewayWidth = 0;
            double concreteVolume = 0;
            decimal concreteAmount = 0;
            int concreteRequired = 0;
            decimal finalCost = 0;

            //Parse driveway wwidth and length
            drivewayLength = double.Parse(textBoxLength.Text);
            drivewayWidth = double.Parse(textBoxWidth.Text);


            //calcualte volume required
            concreteVolume = drivewayLength * drivewayWidth * DRIVEWAY_DEPTH;
            //calculate kilograms required
            concreteAmount = (decimal)concreteVolume / (decimal)CONCRETE_PER_KG;
            //kilograms bags required
            concreteRequired = (int)concreteAmount / (int)BAG_WEIGHT;
            //calculate final cost
            finalCost = (decimal)concreteRequired * BAG_COST;

            textBoxVolume.Text = concreteVolume.ToString(".000");
            textBoxAmount.Text = concreteAmount.ToString(".000") + " Kgs";
            textBoxBagsRequired.Text = concreteRequired.ToString();
            textBoxCost.Text = finalCost.ToString("c");
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message);
            }
    }
    private void exitButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        textBoxCost.Clear();
        textBoxWidth.Clear();
        textBoxLength.Clear();
        textBoxAmount.Clear();
        textBoxVolume.Clear();
        textBoxBagsRequired.Clear();

    }

    private void textBoxWidth_TextChanged(object sender, EventArgs e)
    {
        textBoxWidth.Focus();
    }
}
