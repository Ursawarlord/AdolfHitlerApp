using HelixToolkit.Wpf;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using System.IO;
using Vizualizator3D;

namespace CiobanescGermanDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	[Example(null, "Ciobănescul german sau câinele lup este o rasă de câine care se presupune că a apărut prin domesticirea lupului. Considerația are în vedere asemănările aspectului general. Blondi (1941 - 29 aprilie 1945) a fost ciobanul german al lui Adolf Hitler, drept cadou de la Martin Bormann în 1941")]
    public partial class MainWindow : Window
    {
        //Path to the model file
        
        public MainWindow()
        {
            InitializeComponent();   
            ModelVisual3D device3D = new ModelVisual3D();
            // MessageBox.Show(temp);
            var MODEL_PATH = "../../Vizualizator3D/3D_FILES/GermanShepherd/German Shepherd Dog.obj";
            device3D.Content = Display3d(MODEL_PATH);
            // Add to view port
            viewPort3d.Children.Add(device3D);
        }

        /// <summary>
        /// Display 3D Model
        /// </summary>
        /// <param name="model">Path to the Model file</param>
        /// <returns>3D Model Content</returns>
        private Model3D Display3d(string model)
        {
            Model3D device = null;
            try
            {
                //Adding a gesture here
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);

                //Import 3D model file
                ModelImporter import = new ModelImporter();

                //Load the 3D model file
                device = import.Load(model);
            }
            catch (Exception e)
            {
                // Handle exception in case can not file 3D model
                MessageBox.Show("Exception Error : " + e.StackTrace);
            }
            return device;
        }
    }
}