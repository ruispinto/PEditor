using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using PEditor.myclass;

namespace PEditor.myclass
{
    class dataclass : connection_class
    {
        // declaring lists
        public List<string> _vVersion = new List<string>();         // software version
        public List<string> _rVersion = new List<string>();         // date of release
        public List<string> _uVersion = new List<string>();         // date data last update

        // labels
        public List<string> langLabels = new List<string>();        // Language: Errors

        // language (culture)
        public List<string> cultCountry = new List<string>();       // Country
        public List<string> cultCulture = new List<string>();       // Culture (country code + language code)

        // card viewer
        public Int32 cardID { get; set; }                           // Postcard ID
        public List<string> cardNumber = new List<string>();        // Postcard Number (unique numbering)
        public List<string> cardPublisher = new List<string>();     // Companies
        public List<string> cardSubPub = new List<string>();        // Publisher
        public List<string> cardScanned = new List<string>();       // Scanned ?
        public List<string> cardInBlog = new List<string>();        // In the blog ?
        public List<string> cardBlogURL = new List<string>();       // Blog URL
        public List<string> cardLocality = new List<string>();      // Locality
        public List<string> cardRegion = new List<string>();        // Region
        public List<string> cardRegCountry = new List<string>();    // Country (Region)
        public List<string> cardPubCountry = new List<string>();    // Country (Publisher)
        public List<string> cardDescEng = new List<string>();       // Description (English)
        public List<string> cardDescOrg = new List<string>();       // Description (Original)
        public List<string> cardTheme = new List<string>();         // Theme
        public List<string> cardColor = new List<string>();         // Coloring
        public List<string> cardYear = new List<string>();          // Year
        public List<string> cardImgType = new List<string>();       // Image Type
        public List<string> cardImgNumber = new List<string>();     // Number of images in the postcard
        public List<string> cardIsSeries = new List<string>();      // Series ?
        public List<string> cardTotalCards = new List<string>();    // Total number of postcards (counter)
        public List<string> cardSize = new List<string>();          // Size
        public List<string> cardShape = new List<string>();         // Shape
        public List<string> cardOrient = new List<string>();        // Orientation
        public List<string> cardBarcode = new List<string>();       // Barcode
        public List<string> cardMaterial = new List<string>();      // Material
        public List<string> cardCond = new List<string>();          // Country
        public List<string> cardBorders = new List<string>();       // Borders ? (logical --> checked option)
        public List<string> cardFrontTxt = new List<string>();      // Has text in the front ?
        public List<string> cardBackTxt = new List<string>();       // Has text in the back ?
        public List<string> cardFrontColor = new List<string>();    // Front Text Color
        public List<string> cardBackColor = new List<string>();     // Back Text Color
        public List<string> cardDatePurchase = new List<string>();  // Date of purchase
        public List<string> cardCostPrice = new List<string>();     // Cost price
        public List<string> cardWebpage = new List<string>();       // Website
        public List<string> cardIdentical = new List<string>();     // Identical ? (logical --> checked option)
        public List<string> cardEquals1 = new List<string>();       // Equals to (1)
        public List<string> cardDifferences1 = new List<string>();  // Differences between the postcards (1)
        public List<string> cardEquals2 = new List<string>();       // Equals to (2)
        public List<string> cardDifferences2 = new List<string>();  // Differences between the postcards (2)
        public List<string> cardEquals3 = new List<string>();       // Equals to (3)
        public List<string> cardDifferences3 = new List<string>();  // Differences between the postcards (3)
        public List<string> cardEquals4 = new List<string>();       // Equals to (2)
        public List<string> cardDifferences4 = new List<string>();  // Differences between the postcards (2)
        public List<string> cardEquals5 = new List<string>();       // Equals to (3)
        public List<string> cardDifferences5 = new List<string>();  // Differences between the postcards (3)
        public List<string> cardBigDesc = new List<string>();       // Big Description (if needed)
        public List<string> cardSentType = new List<string>();      // Sent type by...
        public List<string> cardTypeDesc = new List<string>();      // Sent type description
        public List<string> cardFrontImgPath = new List<string>();  // Front Image Path (web)
        public List<string> cardBackImgPath = new List<string>();   // Back Image Path (web)

        // series viewer
        public Int32 seriesID { get; set; }                         // Postcard Series ID
        public List<string> seriesMainNumber = new List<string>();  // Main Postcard Number
        public List<string> seriesSecNumber = new List<string>();   // Secondary postcard number
        public List<string> seriesDescEng = new List<string>();     // Description (English)
        public List<string> seriesDescOrg = new List<string>();     // Description (Original)
        public List<string> seriesColor = new List<string>();       // Coloring
        public List<string> seriesOrient = new List<string>();      // Orientation
        public List<string> seriesImgCount = new List<string>();    // Number of images in the postcard
        public List<string> seriesDate = new List<string>();        // Reference Date
        public List<string> seriesYear = new List<string>();        // Year
        public List<string> seriesBarcode = new List<string>();     // Barcode
        public List<string> seriesFrontTxt = new List<string>();    // Has text in the front ?
        public List<string> seriesBackTxt = new List<string>();     // Has text in the back ?
        public List<string> seriesFrontColor = new List<string>();  // Front Text Color
        public List<string> seriesBackColor = new List<string>();   // Back Text Color
        public List<string> seriesBigDesc = new List<string>();     // Big Description (if needed)
        public List<string> seriesFrontImg = new List<string>();    // Front Image Path (web / hdd)
        public List<string> seriesBackImg = new List<string>();     // Back Image Path (web / hdd

        // tables
        public List<string> dataPub = new List<string>();           // publishers table
        public List<string> dataCountry = new List<string>();       // countries table
        public List<string> dataTheme = new List<string>();         // themes table
        public List<string> dataColor = new List<string>();         // colors table
        public List<string> dataYear = new List<string>();          // years table
        public List<string> dataImgType = new List<string>();       // image types table
        public List<string> dataSize = new List<string>();          // sizes table
        public List<string> dataShape = new List<string>();         // shapes table
        public List<string> dataOrient = new List<string>();        // orientation table
        public List<string> dataMaterial = new List<string>();      // materials table
        public List<string> dataCond = new List<string>();          // conditions table
        public List<string> dataEquals = new List<string>();        // publishers table
        public List<string> dataSentType = new List<string>();      // sent type table

        // others
        public Int32 othersID { get; set; }
        public List<string> fieldData1 = new List<string>();        // field 1
        public List<string> fieldData2 = new List<string>();        // field 2
        public List<string> fieldData3 = new List<string>();        // field 3
        public List<string> fieldData4 = new List<string>();        // field 4
        public List<string> fieldData5 = new List<string>();        // field 5
        public Int32 fieldData6 { get; set; }                       // field 6 (integer only)
        public Int32 fieldData7 { get; set; }                       // field 7 (integer only)

        // language code (default)
        public bool isDBOpen, addSeriesCard = false;

        // read properties
        public DataTable DT = new DataTable();
        public DataSet DS = new DataSet();



        // ****************************************************************************************************
        // * 
        // *  Get software information
        // * 
        // ****************************************************************************************************

        // Show data from the table 'Card' in the grid
        public void _GETVERSION()
        {
            string query = "SELECT csoftversion, csoftvdate, csoftudate FROM cardsoft WHERE csofttype = 1;";
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    connectdb.Open();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectdb;
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        _vVersion.Add(rd[0].ToString());  // software version
                        _rVersion.Add(rd[1].ToString());  // date of release
                        _uVersion.Add(rd[2].ToString());  // database last update date
                    }
                    connectdb.Close();
                    isDBOpen = true;
                }
                catch
                {
                    isDBOpen = false;
                }
            }
        }



        // ****************************************************************************************************
        // * 
        // *  Refresh tables
        // * 
        // ****************************************************************************************************

        // Show data from the table 'Card' in the grid
        public void REFRESH_CARD(string requestedOrder)
        {
            string query;
            if (langLabels[0] == "en-US" || langLabels[0] == "en-UK")
            {
                try
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddesceng AS '" + langLabels[37] + "' FROM card ORDER BY " + requestedOrder;
                }
                catch
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddesceng AS '" + langLabels[37] + "' FROM card";
                }
            }
            else
            {
                try
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddescoriginal AS '" + langLabels[37] + "' FROM card ORDER BY " + requestedOrder;
                }
                catch
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddescoriginal AS '" + langLabels[37] + "' FROM card";
                }
            }
            DS = new DataSet();
            DT.Clear();
            MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
            DA.Fill(DS);
            DT = DS.Tables[0];
        }

        // Show data from the table 'Card' in the grid
        public void REFRESH_SERIES(string requestedOrder)
        {
            string query;
            if (langLabels[0] == "en-US" || langLabels[0] == "en-UK")
            {
                query = "SELECT seriesid AS '#', seriescardnumber AS '" + langLabels[99] + "', seriesseccardnumber AS '" + langLabels[100] + "', seriesdesceng AS '" + langLabels[37] + "' FROM cardseries ORDER BY " + requestedOrder;
            }
            else
            {
                query = "SELECT seriesid AS '#', seriescardnumber AS '" + langLabels[99] + "', seriesseccardnumber AS '" + langLabels[100] + "', seriesdescoriginal AS '" + langLabels[40] + "' FROM cardseries ORDER BY " + requestedOrder;
            }

            try
            {
                connectdb.Close();

                connectdb.Open();
                DS = new DataSet();
                DT.Clear();
                MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
                DA.Fill(DS);
                DT = DS.Tables[0];
            }
            catch
            {

            }
        }

        // Show data from the other tables in the grid
        public void REFRESH_TABLES(int _mOption, string requestedOrder)
        {
            string query = "";
            switch (_mOption)
            {
                case 3:     // colors
                    query = "SELECT coloringid AS '#', coloringabr AS '" + langLabels[107] + "', coloringname AS '" + langLabels[11] + "', coloringdesc AS '" + langLabels[108] + "' FROM coloring";
                    break;
                case 4:     // conditions
                    query = "SELECT condid AS '#', condabr AS '" + langLabels[107] + "', condname AS '" + langLabels[12] + "', conddesc AS '" + langLabels[108] + "' FROM cond";
                    break;
                case 5:     // countries
                    query = "SELECT countryid AS '#', countryname AS '" + langLabels[13] + "', countryiso AS '" + langLabels[111] + "', countryculture AS '" + langLabels[112] + "', countrylang AS '" + langLabels[109] + "', countrydesc AS '" + langLabels[108] + "' FROM countries";
                    break;
                case 6:     // image type
                    query = "SELECT imgtypeid AS '#', imgtypeabr AS '" + langLabels[107] + "', imgtypename AS '" + langLabels[15] + "', imgtypedesc AS '" + langLabels[108] + "' FROM imgtype";
                    break;
                case 7:     // materials
                    query = "SELECT materialid AS '#', materialname AS '" + langLabels[16] + "', materialdesc AS '" + langLabels[108] + "' FROM material";
                    break;
                case 8:     // orientation
                    query = "SELECT orientid AS '#', orientabr AS '" + langLabels[107] + "', orientname AS '" + langLabels[17] + "', orientdesc AS '" + langLabels[108] + "' FROM orient";
                    break;
                case 9:     // publishers
                    query = "SELECT publishid AS '#', publisher AS '" + langLabels[18] + "', publishcompanies AS '" + langLabels[41] + "', publishdesc AS '" + langLabels[108] + "' FROM publishers ORDER BY " + requestedOrder;
                    break;
                case 10:    // sent types
                    query = "SELECT senttypeid AS '#', senttypename AS '" + langLabels[19] + "', senttypedesc AS '" + langLabels[108] + "' FROM senttype";
                    break;
                case 11:    // shapes
                    query = "SELECT shapeid AS '#', shapename AS '" + langLabels[20] + "', shapedesc AS '" + langLabels[108] + "' FROM shape";
                    break;
                case 12:    // sizes
                    query = "SELECT sizeid AS '#', sizename AS '" + langLabels[21] + "', sizedesc AS '" + langLabels[108] + "' FROM size";
                    break;
                case 13:    // themes
                    query = "SELECT themeid AS '#', themename AS '" + langLabels[22] + "', themedesc AS '" + langLabels[108] + "' FROM themes ORDER BY " + requestedOrder;
                    break;
                case 14:    // years
                    query = "SELECT yearid AS '#', yearnumber AS '" + langLabels[23] + "' FROM yyear ORDER BY " + requestedOrder;
                    break;
                case 15:    // languages
                    query = "SELECT langtableid AS '#', langcountry AS '" + langLabels[13] + "', langculture AS '" + langLabels[112] + "' FROM langtable";
                    break;
                case 16:    // labels by language
                    query = "SELECT langid AS '#', langsoft AS '" + langLabels[113] + "', langculture AS '" + langLabels[112] + "', langdesc AS '" + langLabels[108] + "', applangid AS '" + langLabels[114] + "', langlongdesc AS '" + langLabels[73] + "' FROM applang";
                    break;
            }
            try
            {
                connectdb.Close();

                connectdb.Open();
                DS = new DataSet();
                DT.Clear();
                MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
                DA.Fill(DS);
                DT = DS.Tables[0];
            }
            catch
            {

            }
        }



        // *******************************************************************************************************
        // * 
        // *  Search
        // * 
        // * *****************************************************************************************************

        // Search through the cards
        public void SEARCH_CARD(string searchText, string requestedOrder)
        {
            string query;
            if (langLabels[0] == "en-US" || langLabels[0] == "en-UK")
            {
                if (requestedOrder != "")
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddesceng AS '" + langLabels[37] + "' FROM card WHERE CONCAT_WS(' ', cardnumber, cardsubpub, cardcountryname, carddesceng, cardthemename) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                }
                else
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddesceng AS '" + langLabels[37] + "' FROM card WHERE CONCAT_WS(' ', cardnumber, cardsubpub, cardcountryname, carddesceng, cardthemename) LIKE '%" + searchText + "%'";
                }
            }
            else
            {
                if (requestedOrder != "")
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddescoriginal AS '" + langLabels[37] + "' FROM card WHERE CONCAT_WS(' ', cardnumber, cardsubpub, cardcountryname, carddescoriginal, cardthemename) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                }
                else
                {
                    query = "SELECT cardid AS '#', cardnumber AS '" + langLabels[34] + "', cardsubpub AS '" + langLabels[35] + "', cardcountryname AS '" + langLabels[13] + "', cardthemename AS '" + langLabels[36] + "', carddescoriginal AS '" + langLabels[37] + "' FROM card WHERE CONCAT_WS(' ', cardnumber, cardsubpub, cardcountryname, carddescoriginal, cardthemename) LIKE '%" + searchText + "%'";
                }
            }
            try
            {
                connectdb.Close();

                connectdb.Open();
                DS = new DataSet();
                DT.Clear();
                MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
                DA.Fill(DS);
                DT = DS.Tables[0];
            }
            catch
            {

            }
        }

        // Search through the card's series
        public void SEARCH_SERIES(string searchText, string requestedOrder)
        {
            string query;
            if (langLabels[0] == "en-US" || langLabels[0] == "en-UK")
                query = "SELECT seriesid AS '#', seriescardnumber AS '" + langLabels[99] + "', seriesseccardnumber AS '" + langLabels[100] + "', seriesdesceng AS '" + langLabels[37] + "' FROM cardseries WHERE CONCAT_WS(' ', seriescardnumber, seriesseccardnumber, seriesdesceng) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
            else
                query = "SELECT seriesid AS '#', seriescardnumber AS '" + langLabels[99] + "', seriesseccardnumber AS '" + langLabels[100] + "', seriesdescoriginal AS '" + langLabels[40] + "' FROM cardseries WHERE CONCAT_WS(' ', seriescardnumber, seriesseccardnumber, seriesdescoriginal) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
            try
            {
                connectdb.Close();

                connectdb.Open();
                DS = new DataSet();
                DT.Clear();
                MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
                DA.Fill(DS);
                DT = DS.Tables[0];
            }
            catch
            {

            }
        }

        // Search through the other tables
        public void SEARCH_OTHERS(int _mOption, string searchText, string requestedOrder)
        {
            string query = "";
            switch (_mOption)
            {
                case 3:     // colors
                    query = "SELECT coloringid AS '#', coloringabr AS '" + langLabels[107] + "', coloringname AS '" + langLabels[11] + "', coloringdesc AS '" + langLabels[108] + "' FROM coloring WHERE CONCAT_WS(' ', coloringid, coloringabr, coloringname, coloringdesc) LIKE '%" + searchText + "%'";
                    break;
                case 4:     // conditions
                    query = "SELECT condid AS '#', condabr AS '" + langLabels[107] + "', condname AS '" + langLabels[12] + "', conddesc AS '" + langLabels[108] + "' FROM cond WHERE CONCAT_WS(' ', condid, condabr, condname, conddesc) LIKE '%" + searchText + "%'";
                    break;
                case 5:     // countries
                    query = "SELECT countryid AS '#', countryname AS '" + langLabels[13] + "', countryiso AS '" + langLabels[111] + "', countrycuture AS '" + langLabels[112] + "', countrylang AS '" + langLabels[109] + "', countrydesc AS '" + langLabels[108] + "' FROM countries  WHERE CONCAT_WS(' ', countryid, countryname, countryiso, countrylang, countrydesc) LIKE '%" + searchText + "%'";
                    break;
                case 6:     // image type
                    query = "SELECT imgtypeid AS '#', imgtypeabr AS '" + langLabels[107] + "', imgtypename AS '" + langLabels[15] + "', imgtypedesc AS '" + langLabels[108] + "' FROM imgtype WHERE CONCAT_WS(' ', imgtypeid, imgtypeabr, imgtypename, imgtypedesc) LIKE '%" + searchText + "%'";
                    break;
                case 7:     // materials
                    query = "SELECT materialid AS '#', materialname AS '" + langLabels[16] + "', materialdesc AS '" + langLabels[108] + "' FROM material WHERE CONCAT_WS(' ', materialid, materialname, materialdesc) LIKE '%" + searchText + "%'";
                    break;
                case 8:     // orientation
                    query = "SELECT orientid AS '#', orientabr AS '" + langLabels[107] + "', orientname AS '" + langLabels[17] + "', orientdesc AS '" + langLabels[108] + "' FROM orient WHERE CONCAT_WS(' ', orientid, orientabr, oritentname, orientdesc) LIKE '%" + searchText + "%'";
                    break;
                case 9:     // publishers
                    query = "SELECT publishid AS '#', publisher AS '" + langLabels[18] + "', publishcompanies AS '" + langLabels[41] + "', publishdesc AS '" + langLabels[108] + "' FROM publishers WHERE CONCAT_WS(' ', publishid, publisher, publishcompanies, publishdesc) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                    break;
                case 10:    // sent types
                    query = "SELECT senttypeid AS '#', senttypename AS '" + langLabels[19] + "', senttypedesc AS '" + langLabels[108] + "' FROM senttype WHERE CONCAT_WS(' ', senttypeid, senttypename, senttypedesc) LIKE '%" + searchText + "%'";
                    break;
                case 11:    // shapes
                    query = "SELECT shapeid AS '#', shapename AS '" + langLabels[20] + "', shapedesc AS '" + langLabels[108] + "' FROM shape WHERE CONCAT_WS(' ', shapeid, shapename, shapedesc) LIKE '%" + searchText + "%'";
                    break;
                case 12:    // sizes
                    query = "SELECT sizeid AS '#', sizename AS '" + langLabels[21] + "', sizedesc AS '" + langLabels[108] + "' FROM size WHERE CONCAT_WS(' ', sizeid, sizename, sizedesc) LIKE '%" + searchText + "%'";
                    break;
                case 13:    // themes
                    query = "SELECT themeid AS '#', themename AS '" + langLabels[22] + "', themedesc AS '" + langLabels[108] + "' FROM themes WHERE CONCAT_WS(' ', themeid, themename, themedesc) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                    break;
                case 14:    // years
                    query = "SELECT yearid AS '#', yearnumber AS '" + langLabels[23] + "' FROM yyear ORDER BY " + requestedOrder;
                    break;
                case 15:    // languages
                    query = "SELECT langtableid AS '#', langcountry AS '" + langLabels[13] + "', langculture AS '" + langLabels[112] + "' FROM langtable WHERE CONCAT_WS(' ', langtableid, langcountry, langculture) LIKE '%" + searchText + "%'";
                    break;
                case 16:    // labels by language
                    query = "SELECT langid AS '#', langsoft AS '" + langLabels[113] + "', langculture AS '" + langLabels[112] + "', langdesc AS '" + langLabels[108] + "', applangid AS '" + langLabels[114] + "', langlongdesc AS '" + langLabels[73] + "' FROM applang WHERE CONCAT_WS(' ', langid, langsoft, langculture, langdesc, applangid, langlongdesc) LIKE '%" + searchText + "%'";
                    break;
            }
            try
            {
                connectdb.Close();

                connectdb.Open();
                DS = new DataSet();
                DT.Clear();
                MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
                DA.Fill(DS);
                DT = DS.Tables[0];
            }
            catch
            {

            }
        }

        // Search for cardnumber only
        public bool SEARCH_CARDNUMBER()
        {
            bool check = false;
            int checkNumber = 0;
            connectdb.Open();
            MySqlDataReader reader;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT cardnumber FROM card WHERE cardnumber=@cnumber";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                cmd.Parameters.Add("@cnumber", MySqlDbType.VarChar).Value = cardNumber[0];
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkNumber++;
                }
                connectdb.Close();
                if (checkNumber >= 1)
                    check = true;
                else
                    check = false;
            }
            return check;
        }

       // Search for seriescardnumber and seriesseccardnumber (both have to be true)
       public bool SEARCH_SERIESNUMBER()
        {
            bool check = false;
            int checkNumber = 0;
            connectdb.Open();
            MySqlDataReader reader;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT seriescardnumber, seriesseccardnumber FROM cardseries WHERE seriescardnumber=@cmainnumber AND seriesseccardnumber=@csecnumber";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                cmd.Parameters.Add("@cmainnumber", MySqlDbType.VarChar).Value = seriesMainNumber[0];
                cmd.Parameters.Add("@csecnumber", MySqlDbType.VarChar).Value = seriesSecNumber[0];
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkNumber++;
                }
                connectdb.Close();
                if (checkNumber >= 1)
                    check = true;
                else
                    check = false;
            }
            return check;
        }



        // *******************************************************************************************************
        // * 
        // *  Get card/seriescard from database
        // * 
        // * *****************************************************************************************************
        public void TEMP_CARD(Int32 _regCard)
        {
            /*
             * 
             */
            string query = "SELECT cardnumber, cardpublisher, cardsubpub, cardscanned, cardintheblog, cardblogurl, cardlocality, cardregion, cardregcountry, cardcountryname, carddesceng, carddescoriginal, cardthemename, cardcoloringabr, cardyearnumber, cardimgtype, cardimgnmbr, cardseriesmulti, cardsizename, cardshapename, cardorientabr, cardbarcode, cardmaterial, cardcondabr, cardborders, cardtxtfront, cardtxtback, cardfronttxtcolor, cardbacktxtcolor, carddatepurchased, cardcostprice, cardwebpage, cardidentical, cardequalsto, carddifferences, cardequalsto2, carddifferences2, cardequalsto3, carddifferences3, cardequalsto4, carddifferences4, cardequalsto5, carddifferences5, cardbigdesc, cardsenttypename, cardtypedesc, cardfrontimgpath, cardbackimgpath FROM card WHERE cardid=" + _regCard + ";";
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    connectdb.Open();
                }
                catch
                {
                }
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cardNumber.Add(rd[0].ToString());           // Card Number
                    cardPublisher.Add(rd[1].ToString());        // Publishers
                    cardSubPub.Add(rd[2].ToString());           // Publisher (only one)
                    cardScanned.Add(rd[3].ToString());          // Is scanned ?
                    cardInBlog.Add(rd[4].ToString());           // Is in the blog ?
                    cardBlogURL.Add(rd[5].ToString());          // Blog URL
                    cardLocality.Add(rd[6].ToString());         // Locality
                    cardRegion.Add(rd[7].ToString());           // Region
                    cardRegCountry.Add(rd[8].ToString());       // Country (region)
                    cardPubCountry.Add(rd[9].ToString());       // Country (publisher)
                    cardDescEng.Add(rd[10].ToString());         // Description (English)
                    cardDescOrg.Add(rd[11].ToString());         // Description (Original)
                    cardTheme.Add(rd[12].ToString());           // Theme
                    cardColor.Add(rd[13].ToString());           // Coloring
                    cardYear.Add(rd[14].ToString());            // Year
                    cardImgType.Add(rd[15].ToString());         // Image Type
                    cardImgNumber.Add(rd[16].ToString());       // Number of images
                    cardIsSeries.Add(rd[17].ToString());        // Is Series ?
                    cardSize.Add(rd[18].ToString());            // Size
                    cardShape.Add(rd[19].ToString());           // Shape
                    cardOrient.Add(rd[20].ToString());          // Orientation
                    cardBarcode.Add(rd[21].ToString());         // Barcode
                    cardMaterial.Add(rd[22].ToString());        // Material
                    cardCond.Add(rd[23].ToString());            // Condition
                    cardBorders.Add(rd[24].ToString());         // Borders ?
                    cardFrontTxt.Add(rd[25].ToString());        // Has text in the front ?
                    cardBackTxt.Add(rd[26].ToString());         // Has text in the back ?
                    cardFrontColor.Add(rd[27].ToString());      // Front Text Color
                    cardBackColor.Add(rd[28].ToString());       // Back Text Color
                    cardDatePurchase.Add(rd[29].ToString());    // Date of Purchase
                    cardCostPrice.Add(rd[30].ToString());       // Cost Price
                    cardWebpage.Add(rd[31].ToString());         // Website
                    cardIdentical.Add(rd[32].ToString());       // Identical ?
                    cardEquals1.Add(rd[33].ToString());         // Equals to (1)
                    cardDifferences1.Add(rd[34].ToString());    // Differences(1)
                    cardEquals2.Add(rd[35].ToString());         // Equals to (2)
                    cardDifferences2.Add(rd[36].ToString());    // Differences(2)
                    cardEquals3.Add(rd[37].ToString());         // Equals to (3)
                    cardDifferences3.Add(rd[38].ToString());    // Differences(3)
                    cardEquals4.Add(rd[39].ToString());         // Equals to (4)
                    cardDifferences4.Add(rd[40].ToString());    // Differences (4)
                    cardEquals5.Add(rd[41].ToString());         // Equals to (5)
                    cardDifferences5.Add(rd[42].ToString());    // Differences (5)
                    cardBigDesc.Add(rd[43].ToString());         // Big Description
                    cardSentType.Add(rd[44].ToString());        // Sent Type (bought by/offered by/sent by)
                    cardTypeDesc.Add(rd[45].ToString());        // Type description
                    cardFrontImgPath.Add(rd[46].ToString());    // Front Image Path (web)
                    cardBackImgPath.Add(rd[47].ToString());     // Back Image Path (web)
                }
                connectdb.Close();
                try
                {
                    if (cardIsSeries[0].ToUpper().ToString() == "Y")
                    {
                        query = "SELECT COUNT(*) FROM cardseries WHERE seriescardnumber = '" + cardNumber[0] + "'";
                        MySqlDataReader rd2;
                        using (var cmd2 = new MySqlCommand())
                        {
                            try
                            {
                                connectdb.Open();
                            }
                            catch
                            {
                            }
                            cmd2.CommandText = query;
                            cmd2.CommandType = CommandType.Text;
                            cmd2.Connection = connectdb;
                            rd2 = cmd2.ExecuteReader();
                            while (rd2.Read())
                            {
                                cardTotalCards.Add(rd2[0].ToString());      // Total Postcards of this serie
                            }
                        }
                        connectdb.Close();
                    }
                }
                catch
                {

                }
            }
        }

        public void TEMP_SERIES(Int32 _regCard)
        {
            string query = "SELECT seriescardnumber, seriesseccardnumber, seriesdesceng, seriesdescoriginal, seriescolorabr, seriesorientabr, seriesimgcount, seriesdate, seriesyearnumber, seriesbarcode, seriesfronttxt, seriesbacktxt, seriesfronttxtcolor, seriesbacktxtcolor, seriesbigdesc, seriesfrontimgpath, seriesbackimgpath from cardseries WHERE seriesid=" + _regCard + ";";
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    connectdb.Open();
                }
                catch
                {
                }
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    seriesMainNumber.Add(rd[0].ToString());     // Main Postcard Number
                    seriesSecNumber.Add(rd[1].ToString());      // Secondary postcard number
                    seriesDescEng.Add(rd[2].ToString());        // Description (English)
                    seriesDescOrg.Add(rd[3].ToString());        // Description (Original)
                    seriesColor.Add(rd[4].ToString());          // Coloring
                    seriesOrient.Add(rd[5].ToString());         // Orientation
                    seriesImgCount.Add(rd[6].ToString());       // Number of images in the postcard
                    seriesDate.Add(rd[7].ToString());           // Reference Date
                    seriesYear.Add(rd[8].ToString());           // Year
                    seriesBarcode.Add(rd[9].ToString());        // Barcode
                    seriesFrontTxt.Add(rd[10].ToString());      // Has text in the front ?
                    seriesBackTxt.Add(rd[11].ToString());       // Has text in the back ?
                    seriesFrontColor.Add(rd[12].ToString());    // Front Text Color
                    seriesBackColor.Add(rd[13].ToString());     // Back Text Color
                    seriesBigDesc.Add(rd[14].ToString());       // Big Description (if needed)
                    seriesFrontImg.Add(rd[15].ToString());      // Front Image Path (web / hdd)
                    seriesBackImg.Add(rd[16].ToString());       // Back Image Path (web / hdd
                }
                connectdb.Close();
            }
        }



        // *******************************************************************************************************
        // * 
        // *  Get language labels from database
        // * 
        // * *****************************************************************************************************
        public void TEMP_LABELS(int _langType, string _langCulture)
        {
            /*
             * 
             */
            string query = "SELECT langDesc from applang WHERE langsoft=" + _langType + " AND langculture='" + _langCulture + "';";
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    connectdb.Open();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectdb;
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        langLabels.Add(rd[0].ToString());     // Labels and Description
                    }
                    connectdb.Close();
                }
                catch
                {
                }
            }
        }



        // *******************************************************************************************************
        // * 
        // *  Get language culture from database
        // * 
        // * *****************************************************************************************************
        public void TEMP_CULTURE()
        {
            /*
             * 
             */
            string query = "SELECT langcountry, langculture from langtable;";
            //string query = "SELECT distinct(countrylang), countryculture from countries";
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    connectdb.Open();
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = connectdb;
                    rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        cultCountry.Add(rd[0].ToString());  // Country
                        cultCulture.Add(rd[1].ToString());  // Culture
                    }
                    connectdb.Close();
                    /*
                    * for future use when table countries will be available
                    */
                    //for (int i = 0; i < cultCountry.Count; i++)
                    //{
                    //    if (cultCountry[i] == null || cultCountry[i] == "" || cultCountry[i].Length == 0)
                    //    {
                    //        cultCountry.RemoveAt(i);
                    //        cultCulture.RemoveAt(i);
                    //    }
                    //}
                }
                catch
                {
                }
            }
        }



        // *******************************************************************************************************
        // * 
        // *  Get data from database tables
        // * 
        // * *****************************************************************************************************
        public void fillPub()
        {
            dataPub.Clear();
            MySqlDataReader rd;
            string query = "SELECT publisher FROM publishers";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataPub.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillCountry()
        {
            dataCountry.Clear();
            MySqlDataReader rd;
            string query = "SELECT countryname FROM countries";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataCountry.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillTheme()
        {
            dataTheme.Clear();
            MySqlDataReader rd;
            string query = "SELECT themename FROM themes";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataTheme.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillColor()
        {
            dataColor.Clear();
            MySqlDataReader rd;
            string query = "SELECT coloringabr FROM coloring";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataColor.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillImgType()
        {
            dataImgType.Clear();
            MySqlDataReader rd;
            string query = "SELECT imgtypeabr FROM imgtype";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataImgType.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillYear()
        {
            dataYear.Clear();
            MySqlDataReader rd;
            string query = "SELECT yearnumber FROM yyear";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataYear.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillSize()
        {
            dataSize.Clear();
            MySqlDataReader rd;
            string query = "SELECT sizename FROM size";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataSize.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillShape()
        {
            dataShape.Clear();
            MySqlDataReader rd;
            string query = "SELECT shapename FROM shape";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataShape.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillOrient()
        {
            dataOrient.Clear();
            MySqlDataReader rd;
            string query = "SELECT orientabr FROM orient";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataOrient.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillMaterial()
        {
            dataMaterial.Clear();
            MySqlDataReader rd;
            string query = "SELECT materialname FROM material";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataMaterial.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillCond()
        {
            dataCond.Clear();
            MySqlDataReader rd;
            string query = "SELECT condabr FROM cond";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataCond.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillCardNumber()
        {
            dataEquals.Clear();
            MySqlDataReader rd;
            string query = "SELECT cardnumber FROM card";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataEquals.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }
        public void fillSentType()
        {
            dataSentType.Clear();
            MySqlDataReader rd;
            string query = "SELECT senttypename FROM senttype";
            using (var cmd = new MySqlCommand())
            {
                connectdb.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    dataSentType.Add(rd[0].ToString());
                }
                connectdb.Close();
            }
        }



        // *******************************************************************************************************
        // * 
        // *  Postcards
        // * 
        // * *****************************************************************************************************
        public void ADD_CARD()
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            string query = "INSERT INTO card(cardnumber, cardpublisher, cardsubpub, cardscanned, cardintheblog, cardblogurl, cardlocality, cardregion, cardregcountry, cardcountryname, carddesceng, carddescoriginal, cardthemename, cardcoloringabr, cardyearnumber, cardimgtype, cardimgnmbr, cardseriesmulti, cardsizename, cardshapename, cardorientabr, cardbarcode, cardmaterial, cardcondabr, cardborders, cardtxtfront, cardtxtback, cardfronttxtcolor, cardbacktxtcolor, carddatepurchased, cardcostprice, cardwebpage, cardidentical, cardequalsto, carddifferences, cardequalsto2, carddifferences2, cardequalsto3, carddifferences3, cardequalsto4, carddifferences4, cardequalsto5, carddifferences5, cardsenttypename, cardtypedesc, cardbigdesc, cardfrontimgpath, cardbackimgpath) VALUES(@cnumber, @cpub, @csubpub, @cscan, @cblog, @cblogurl, @clocality, @cregion, @cregcountry, @cpubcountry, @cdesceng, @cdescorig, @ctheme, @ccolor, @cyear, @cimgtype, @cimgnmbr, @cseries, @csize, @cshape, @corient, @cbarcode, @cmaterial, @ccond, @cborders, @ctxtfront, @ctxtback, @cfrontcolor, @cbackcolor, @cdatepurchase, @cprice, @cweb, @cidentical, @cequals1, @cdiff1, @cequals2, @cdiff2, @cequals3, @cdiff3, @cequals4, @cdiff4, @cequals5, @cdiff5, @csenttype, @ctypedesc, @cbigdesc, @cfrontimg, @cbackimg)";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                // add app fields data to the database fields
                cmd.Parameters.Add("@cnumber", MySqlDbType.VarChar).Value = cardNumber[0];
                cmd.Parameters.Add("@cpub", MySqlDbType.VarChar).Value = cardPublisher[0];
                cmd.Parameters.Add("@csubpub", MySqlDbType.VarChar).Value = cardSubPub[0];
                cmd.Parameters.Add("@cscan", MySqlDbType.VarChar).Value = cardScanned[0];
                cmd.Parameters.Add("@cblog", MySqlDbType.VarChar).Value = cardInBlog[0];
                cmd.Parameters.Add("@cblogurl", MySqlDbType.VarChar).Value = cardBlogURL[0];
                cmd.Parameters.Add("@clocality", MySqlDbType.VarChar).Value = cardLocality[0];
                cmd.Parameters.Add("@cregion", MySqlDbType.VarChar).Value = cardRegion[0];
                cmd.Parameters.Add("@cregcountry", MySqlDbType.VarChar).Value = cardRegCountry[0];
                cmd.Parameters.Add("@cpubcountry", MySqlDbType.VarChar).Value = cardPubCountry[0];
                cmd.Parameters.Add("@cdesceng", MySqlDbType.VarChar).Value = cardDescEng[0];
                cmd.Parameters.Add("@cdescorig", MySqlDbType.VarChar).Value = cardDescOrg[0];
                cmd.Parameters.Add("@ctheme", MySqlDbType.VarChar).Value = cardTheme[0];
                cmd.Parameters.Add("@ccolor", MySqlDbType.VarChar).Value = cardColor[0];
                cmd.Parameters.Add("@cyear", MySqlDbType.VarChar).Value = cardYear[0];
                cmd.Parameters.Add("@cimgtype", MySqlDbType.VarChar).Value = cardImgType[0];
                cmd.Parameters.Add("@cimgnmbr", MySqlDbType.VarChar).Value = cardImgNumber[0];
                cmd.Parameters.Add("@cseries", MySqlDbType.VarChar).Value = cardIsSeries[0];
                cmd.Parameters.Add("@csize", MySqlDbType.VarChar).Value = cardSize[0];
                cmd.Parameters.Add("@cshape", MySqlDbType.VarChar).Value = cardShape[0];
                cmd.Parameters.Add("@corient", MySqlDbType.VarChar).Value = cardOrient[0];
                cmd.Parameters.Add("@cbarcode", MySqlDbType.VarChar).Value = cardBarcode[0];
                cmd.Parameters.Add("@cmaterial", MySqlDbType.VarChar).Value = cardMaterial[0];
                cmd.Parameters.Add("@ccond", MySqlDbType.VarChar).Value = cardCond[0];
                cmd.Parameters.Add("@cborders", MySqlDbType.VarChar).Value = cardBorders[0];
                cmd.Parameters.Add("@ctxtfront", MySqlDbType.VarChar).Value = cardFrontTxt[0];
                cmd.Parameters.Add("@ctxtback", MySqlDbType.VarChar).Value = cardBackTxt[0];
                cmd.Parameters.Add("@cfrontcolor", MySqlDbType.VarChar).Value = cardFrontColor[0];
                cmd.Parameters.Add("@cbackcolor", MySqlDbType.VarChar).Value = cardBackColor[0];
                cmd.Parameters.Add("@cdatepurchase", MySqlDbType.VarChar).Value = cardDatePurchase[0];
                cmd.Parameters.Add("@cprice", MySqlDbType.VarChar).Value = cardCostPrice[0];
                cmd.Parameters.Add("@cweb", MySqlDbType.VarChar).Value = cardWebpage[0];
                cmd.Parameters.Add("@cidentical", MySqlDbType.VarChar).Value = cardIdentical[0];
                cmd.Parameters.Add("@cequals1", MySqlDbType.VarChar).Value = cardEquals1[0];
                cmd.Parameters.Add("@cdiff1", MySqlDbType.VarChar).Value = cardDifferences1[0];
                cmd.Parameters.Add("@cequals2", MySqlDbType.VarChar).Value = cardEquals2[0];
                cmd.Parameters.Add("@cdiff2", MySqlDbType.VarChar).Value = cardDifferences2[0];
                cmd.Parameters.Add("@cequals3", MySqlDbType.VarChar).Value = cardEquals3[0];
                cmd.Parameters.Add("@cdiff3", MySqlDbType.VarChar).Value = cardDifferences3[0];
                cmd.Parameters.Add("@cequals4", MySqlDbType.VarChar).Value = cardEquals4[0];
                cmd.Parameters.Add("@cdiff4", MySqlDbType.VarChar).Value = cardDifferences4[0];
                cmd.Parameters.Add("@cequals5", MySqlDbType.VarChar).Value = cardEquals5[0];
                cmd.Parameters.Add("@cdiff5", MySqlDbType.VarChar).Value = cardDifferences5[0];
                cmd.Parameters.Add("@cbigdesc", MySqlDbType.VarChar).Value = cardBigDesc[0];
                cmd.Parameters.Add("@csenttype", MySqlDbType.VarChar).Value = cardSentType[0];
                cmd.Parameters.Add("@ctypedesc", MySqlDbType.VarChar).Value = cardTypeDesc[0];
                cmd.Parameters.Add("@cfrontimg", MySqlDbType.VarChar).Value = cardFrontImgPath[0];
                cmd.Parameters.Add("@cbackimg", MySqlDbType.VarChar).Value = cardBackImgPath[0];

                // execute the query (in this case add a new postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        public void UPDATE_CARD()
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            string query = "UPDATE card SET cardnumber=@cnumber, cardpublisher=@cpub, cardsubpub=@csubpub, cardscanned=@cscan, cardintheblog=@cblog, cardblogurl=@cblogurl, cardlocality=@clocality, cardregion=@cregion, cardregcountry=@cregcountry, cardcountryname=@cpubcountry, carddesceng=@cdesceng, carddescoriginal=@cdescorig, cardthemename=@ctheme, cardcoloringabr=@ccolor, cardyearnumber=@cyear, cardimgtype=@cimgtype, cardimgnmbr=@cimgnmbr, cardseriesmulti=@cseries, cardsizename=@csize, cardshapename=@cshape, cardorientabr=@corient, cardbarcode=@cbarcode, cardmaterial=@cmaterial, cardcondabr=@ccond, cardborders=@cborders, cardtxtfront=@ctxtfront, cardtxtback=@ctxtback, cardfronttxtcolor=@cfrontcolor, cardbacktxtcolor=@cbackcolor, carddatepurchased=@cdatepurchase, cardcostprice=@cprice, cardwebpage=@cweb, cardidentical=@cidentical, cardequalsto=@cequals1, carddifferences=@cdiff1, cardequalsto2=@cequals2, carddifferences2=@cdiff2, cardequalsto3=@cequals3, carddifferences3=@cdiff3, cardequalsto4=@cequals4, carddifferences4=@cdiff4, cardequalsto5=@cequals5, carddifferences5=@cdiff5, cardsenttypename=@csenttype, cardtypedesc=@ctypedesc, cardbigdesc=@cbigdesc, cardfrontimgpath=@cfrontimg, cardbackimgpath=@cbackimg WHERE cardid=@cid";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@cnumber", MySqlDbType.VarChar).Value = cardNumber[0];
                cmd.Parameters.Add("@cpub", MySqlDbType.VarChar).Value = cardPublisher[0];
                cmd.Parameters.Add("@csubpub", MySqlDbType.VarChar).Value = cardSubPub[0];
                cmd.Parameters.Add("@cscan", MySqlDbType.VarChar).Value = cardScanned[0];
                cmd.Parameters.Add("@cblog", MySqlDbType.VarChar).Value = cardInBlog[0];
                cmd.Parameters.Add("@cblogurl", MySqlDbType.VarChar).Value = cardBlogURL[0];
                cmd.Parameters.Add("@clocality", MySqlDbType.VarChar).Value = cardLocality[0];
                cmd.Parameters.Add("@cregion", MySqlDbType.VarChar).Value = cardRegion[0];
                cmd.Parameters.Add("@cregcountry", MySqlDbType.VarChar).Value = cardRegCountry[0];
                cmd.Parameters.Add("@cpubcountry", MySqlDbType.VarChar).Value = cardPubCountry[0];
                cmd.Parameters.Add("@cdesceng", MySqlDbType.VarChar).Value = cardDescEng[0];
                cmd.Parameters.Add("@cdescorig", MySqlDbType.VarChar).Value = cardDescOrg[0];
                cmd.Parameters.Add("@ctheme", MySqlDbType.VarChar).Value = cardTheme[0];
                cmd.Parameters.Add("@ccolor", MySqlDbType.VarChar).Value = cardColor[0];
                cmd.Parameters.Add("@cyear", MySqlDbType.VarChar).Value = cardYear[0];
                cmd.Parameters.Add("@cimgtype", MySqlDbType.VarChar).Value = cardImgType[0];
                cmd.Parameters.Add("@cimgnmbr", MySqlDbType.VarChar).Value = cardImgNumber[0];
                cmd.Parameters.Add("@cseries", MySqlDbType.VarChar).Value = cardIsSeries[0];
                cmd.Parameters.Add("@csize", MySqlDbType.VarChar).Value = cardSize[0];
                cmd.Parameters.Add("@cshape", MySqlDbType.VarChar).Value = cardShape[0];
                cmd.Parameters.Add("@corient", MySqlDbType.VarChar).Value = cardOrient[0];
                cmd.Parameters.Add("@cbarcode", MySqlDbType.VarChar).Value = cardBarcode[0];
                cmd.Parameters.Add("@cmaterial", MySqlDbType.VarChar).Value = cardMaterial[0];
                cmd.Parameters.Add("@ccond", MySqlDbType.VarChar).Value = cardCond[0];
                cmd.Parameters.Add("@cborders", MySqlDbType.VarChar).Value = cardBorders[0];
                cmd.Parameters.Add("@ctxtfront", MySqlDbType.VarChar).Value = cardFrontTxt[0];
                cmd.Parameters.Add("@ctxtback", MySqlDbType.VarChar).Value = cardBackTxt[0];
                cmd.Parameters.Add("@cfrontcolor", MySqlDbType.VarChar).Value = cardFrontColor[0];
                cmd.Parameters.Add("@cbackcolor", MySqlDbType.VarChar).Value = cardBackColor[0];
                cmd.Parameters.Add("@cdatepurchase", MySqlDbType.VarChar).Value = cardDatePurchase[0];
                cmd.Parameters.Add("@cprice", MySqlDbType.VarChar).Value = cardCostPrice[0];
                cmd.Parameters.Add("@cweb", MySqlDbType.VarChar).Value = cardWebpage[0];
                cmd.Parameters.Add("@cidentical", MySqlDbType.VarChar).Value = cardIdentical[0];
                cmd.Parameters.Add("@cequals1", MySqlDbType.VarChar).Value = cardEquals1[0];
                cmd.Parameters.Add("@cdiff1", MySqlDbType.VarChar).Value = cardDifferences1[0];
                cmd.Parameters.Add("@cequals2", MySqlDbType.VarChar).Value = cardEquals2[0];
                cmd.Parameters.Add("@cdiff2", MySqlDbType.VarChar).Value = cardDifferences2[0];
                cmd.Parameters.Add("@cequals3", MySqlDbType.VarChar).Value = cardEquals3[0];
                cmd.Parameters.Add("@cdiff3", MySqlDbType.VarChar).Value = cardDifferences3[0];
                cmd.Parameters.Add("@cequals4", MySqlDbType.VarChar).Value = cardEquals4[0];
                cmd.Parameters.Add("@cdiff4", MySqlDbType.VarChar).Value = cardDifferences4[0];
                cmd.Parameters.Add("@cequals5", MySqlDbType.VarChar).Value = cardEquals5[0];
                cmd.Parameters.Add("@cdiff5", MySqlDbType.VarChar).Value = cardDifferences5[0];
                cmd.Parameters.Add("@cbigdesc", MySqlDbType.VarChar).Value = cardBigDesc[0];
                cmd.Parameters.Add("@csenttype", MySqlDbType.VarChar).Value = cardSentType[0];
                cmd.Parameters.Add("@ctypedesc", MySqlDbType.VarChar).Value = cardTypeDesc[0];
                cmd.Parameters.Add("@cfrontimg", MySqlDbType.VarChar).Value = cardFrontImgPath[0];
                cmd.Parameters.Add("@cbackimg", MySqlDbType.VarChar).Value = cardBackImgPath[0];

                // WHERE clause
                cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = cardID;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        public void DELETE_CARD()
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            string query = "DELETE FROM card WHERE cardid=@cid";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                // WHERE
                cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = cardID;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }



        // *************************************************************************************************
        // * 
        // *  Postcard series
        // * 
        // *************************************************************************************************
        public void ADD_SERIESCARD()
        {
            connectdb.Open();
            string query = "INSERT INTO cardseries(seriescardnumber, seriesseccardnumber, seriesdesceng, seriesdescoriginal, seriescolorabr, seriesorientabr, seriesimgcount, seriesdate, seriesyearnumber, seriesbarcode, seriesfronttxt, seriesbacktxt, seriesfronttxtcolor, seriesbacktxtcolor, seriesbigdesc, seriesfrontimgpath, seriesbackimgpath) VALUES(@smainnumber, @ssecnumber, @sdesceng, @sdescorig, @scolor, @sorient, @simgcount, @sdate, @syear, @sbarcode, @stxtfront, @stxtback, @sfrontcolor, @sbackcolor, @sbigdesc, @sfrontimg, @sbackimg)";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                // add app fields data to the database fields
                cmd.Parameters.Add("@smainnumber", MySqlDbType.VarChar).Value = seriesMainNumber[0];
                cmd.Parameters.Add("@ssecnumber", MySqlDbType.VarChar).Value = seriesSecNumber[0];
                cmd.Parameters.Add("@sdesceng", MySqlDbType.VarChar).Value = seriesDescEng[0];
                cmd.Parameters.Add("@sdescorig", MySqlDbType.VarChar).Value = seriesDescOrg[0];
                cmd.Parameters.Add("@scolor", MySqlDbType.VarChar).Value = seriesColor[0];
                cmd.Parameters.Add("@sorient", MySqlDbType.VarChar).Value = seriesOrient[0];
                cmd.Parameters.Add("@simgcount", MySqlDbType.VarChar).Value = seriesImgCount[0];
                cmd.Parameters.Add("@sdate", MySqlDbType.VarChar).Value = seriesDate[0];
                cmd.Parameters.Add("@syear", MySqlDbType.VarChar).Value = seriesYear[0];
                cmd.Parameters.Add("@sbarcode", MySqlDbType.VarChar).Value = seriesBarcode[0];
                cmd.Parameters.Add("@stxtfront", MySqlDbType.VarChar).Value = seriesFrontTxt[0];
                cmd.Parameters.Add("@stxtback", MySqlDbType.VarChar).Value = seriesBackTxt[0];
                cmd.Parameters.Add("@sfrontcolor", MySqlDbType.VarChar).Value = seriesFrontColor[0];
                cmd.Parameters.Add("@sbackcolor", MySqlDbType.VarChar).Value = seriesBackColor[0];
                cmd.Parameters.Add("@sbigdesc", MySqlDbType.VarChar).Value = seriesBigDesc[0];
                cmd.Parameters.Add("@sfrontimg", MySqlDbType.VarChar).Value = seriesFrontImg[0];
                cmd.Parameters.Add("@sbackimg", MySqlDbType.VarChar).Value = seriesBackImg[0];

                // execute the query (in this case add a new postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }
        public void UPDATE_SERIESCARD()
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            string query = "UPDATE cardseries SET seriescardnumber=@smainnumber, seriesseccardnumber=@ssecnumber, seriesdesceng=@sdesceng, seriesdescoriginal=@sdescorig, seriescolorabr=@scolor, seriesorientabr=@sorient, seriesimgcount=@simgcount, seriesdate=@sdate, seriesyearnumber=@syear, seriesbarcode=@sbarcode, seriesfronttxt=@stxtfront, seriesbacktxt=@stxtback, seriesfronttxtcolor=@sfrontcolor, seriesbacktxtcolor=@sbackcolor, seriesbigdesc=@sbigdesc, seriesfrontimgpath=@sfrontimg, seriesbackimgpath=@sbackimg WHERE seriesid=@sid";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@smainnumber", MySqlDbType.VarChar).Value = seriesMainNumber[0];
                cmd.Parameters.Add("@ssecnumber", MySqlDbType.VarChar).Value = seriesSecNumber[0];
                cmd.Parameters.Add("@sdesceng", MySqlDbType.VarChar).Value = seriesDescEng[0];
                cmd.Parameters.Add("@sdescorig", MySqlDbType.VarChar).Value = seriesDescOrg[0];
                cmd.Parameters.Add("@scolor", MySqlDbType.VarChar).Value = seriesColor[0];
                cmd.Parameters.Add("@sorient", MySqlDbType.VarChar).Value = seriesOrient[0];
                cmd.Parameters.Add("@simgcount", MySqlDbType.VarChar).Value = seriesImgCount[0];
                cmd.Parameters.Add("@sdate", MySqlDbType.VarChar).Value = seriesDate[0];
                cmd.Parameters.Add("@syear", MySqlDbType.VarChar).Value = seriesYear[0];
                cmd.Parameters.Add("@sbarcode", MySqlDbType.VarChar).Value = seriesBarcode[0];
                cmd.Parameters.Add("@stxtfront", MySqlDbType.VarChar).Value = seriesFrontTxt[0];
                cmd.Parameters.Add("@stxtback", MySqlDbType.VarChar).Value = seriesBackTxt[0];
                cmd.Parameters.Add("@sfrontcolor", MySqlDbType.VarChar).Value = seriesFrontColor[0];
                cmd.Parameters.Add("@sbackcolor", MySqlDbType.VarChar).Value = seriesBackColor[0];
                cmd.Parameters.Add("@sbigdesc", MySqlDbType.VarChar).Value = seriesBigDesc[0];
                cmd.Parameters.Add("@sfrontimg", MySqlDbType.VarChar).Value = seriesFrontImg[0];
                cmd.Parameters.Add("@sbackimg", MySqlDbType.VarChar).Value = seriesBackImg[0];

                // WHERE clause
                cmd.Parameters.Add("@sid", MySqlDbType.Int32).Value = seriesID;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        public void DELETE_SERIECARD()
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            string query = "DELETE FROM cardseries WHERE seriesid=@sid";
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                // WHERE
                cmd.Parameters.Add("@sid", MySqlDbType.Int32).Value = cardID;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }




        // *************************************************************************************************
        // * 
        // *  Other tables
        // * 
        // *************************************************************************************************
        public void TEMP_OTHER(Int32 _menuOption, Int32 _regCard)
        {
            string query = "";
            switch (_menuOption)
            {
                case 3:     // colors
                    query = "SELECT coloringabr, coloringname, coloringdesc FROM coloring WHERE coloringid=" + _regCard;
                    break;
                case 4:     // conditions
                    query = "SELECT condabr, condname, conddesc FROM cond WHERE condid=" + _regCard;
                    break;
                case 5:     // countries
                    query = "SELECT countryname, countryiso, countryculture, countrylang, countrydesc FROM countries WHERE countryid=" + _regCard;
                    break;
                case 6:     // image type
                    query = "SELECT imgtypeabr, imgtypename, imgtypedesc FROM imgtype WHERE imgtypeid=" + _regCard;
                    break;
                case 7:     // materials
                    query = "SELECT materialname, materialdesc FROM material WHERE materialid=" + _regCard;
                    break;
                case 8:     // orientation
                    query = "SELECT orientabr, orientname, orientdesc FROM orient WHERE orientid=" + _regCard;
                    break;
                case 9:     // publishers
                    query = "SELECT publisher, publishcompanies, publishdesc FROM publishers WHERE publishid=" + _regCard;
                    break;
                case 10:    // sent types
                    query = "SELECT senttypename, senttypedesc FROM senttype WHERE senttypeid=" + _regCard;
                    break;
                case 11:    // shapes
                    query = "SELECT shapename, shapedesc FROM shape WHERE shapeid=" + _regCard;
                    break;
                case 12:    // sizes
                    query = "SELECT sizename, sizedesc FROM size WHERE sizeid=" + _regCard;
                    break;
                case 13:    // themes
                    query = "SELECT themename, themedesc FROM themes WHERE themeid=" + _regCard;
                    break;
                case 14:    // years
                    query = "SELECT yearnumber FROM yyear WHERE yearid=" + _regCard;
                    break;
                case 15:    // languages
                    query = "SELECT langcountry, langculture FROM langtable WHERE langtableid=" + _regCard;
                    break;
                case 16:    // labels by language
                    query = "SELECT langsoft, langculture, langdesc, applangid, langlongdesc FROM applang WHERE langid=" + _regCard;
                    break;
            }
            MySqlDataReader rd;
            using (var cmd = new MySqlCommand())
            {
                try
                {
                    connectdb.Open();
                }
                catch
                {
                }
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    switch (_menuOption)
                    {
                        case 3:
                        case 4:
                        case 6:
                        case 8:
                        case 9:
                            fieldData1.Add(rd[0].ToString());
                            fieldData2.Add(rd[1].ToString());
                            fieldData3.Add(rd[2].ToString());
                            break;
                        case 5:
                        case 16:
                            fieldData1.Add(rd[0].ToString());
                            fieldData2.Add(rd[1].ToString());
                            fieldData3.Add(rd[2].ToString());
                            fieldData4.Add(rd[3].ToString());
                            fieldData5.Add(rd[4].ToString());
                            break;
                        case 7:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 15:
                            fieldData1.Add(rd[0].ToString());
                            fieldData2.Add(rd[1].ToString());
                            break;
                        case 14:
                            fieldData1.Add(rd[0].ToString());
                            break;
                    }
                }
                connectdb.Close();
            }
        }

        public void ADD_OTHERS(Int32 _menuOption)
        {
            connectdb.Open();
            string query = "";
            switch (_menuOption)
            {
                case 3:     // colors
                    query = "INSERT INTO coloring(coloringabr, coloringname, coloringdesc) VALUES(@field1, @field2, @field3)";
                    break;
                case 4:     // conditions
                    query = "INSERT INTO cond(condabr, condname, conddesc) VALUES(@field1, @field2, @field3)";
                    break;
                case 5:     // countries
                    query = "INSERT INTO countries(countryname, countryiso, countryculture, countrylang, countrydesc) VALUES(@field1, @field2, @field3, @field4, @field5)";
                    break;
                case 6:     // image type
                    query = "INSERT INTO imgtype(imgtypeabr, imgtypename, imgtypedesc) VALUES(@field1, @field2, @field3)";
                    break;
                case 7:     // materials
                    query = "INSERT INTO material(materialname, materialdesc) VALUES(@field1, @field2)";
                    break;
                case 8:     // orientation
                    query = "INSERT INTO orient(orientabr, orientname, orientdesc) VALUES(@field1, @field2, @field3)";
                    break;
                case 9:     // publishers
                    query = "INSERT INTO publishers(publisher, publishcompanies, publishdesc) VALUES(@field1, @field2, @field3)";
                    break;
                case 10:    // sent types
                    query = "INSERT INTO senttype(senttypename, senttypedesc) VALUES(@field1, @field2)";
                    break;
                case 11:    // shapes
                    query = "INSERT INTO shape(shapename, shapedesc) VALUES(@field1, @field2)";
                    break;
                case 12:    // sizes
                    query = "INSERT INTO size(sizename, sizedesc) VALUES(@field1, @field2)";
                    break;
                case 13:    // themes
                    query = "INSERT INTO themes(themepename, themedesc) VALUES(@field1, @field2)";
                    break;
                case 14:    // years
                    query = "INSERT INTO yyear(yearnumber) VALUES(@field1)";
                    break;
                case 15:    // languages
                    query = "INSERT INTO langtable(langcountry, langculture) VALUES(@field1, @field2)";
                    break;
                case 16:    // labels by language
                    query = "INSERT INTO applang(langsoft, langculture, langdesc, applangid, langlongdesc) VALUES(@field6, @field2, @field3, @field7, @field5)";
                    break;
            }
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                // add app fields data to the database fields
                switch (_menuOption)
                {
                    case 3:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = fieldData3[0];
                        break;
                    case 5:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = fieldData3[0];
                        cmd.Parameters.Add("@field4", MySqlDbType.VarChar).Value = fieldData4[0];
                        cmd.Parameters.Add("@field5", MySqlDbType.VarChar).Value = fieldData5[0];
                        break;
                    case 16:
                        cmd.Parameters.Add("@field1", MySqlDbType.Int32).Value = fieldData6;
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = fieldData3[0];
                        cmd.Parameters.Add("@field4", MySqlDbType.Int32).Value = fieldData7;
                        cmd.Parameters.Add("@field5", MySqlDbType.VarChar).Value = fieldData5[0];
                        break;
                    case 7:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 15:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        break;
                    case 14:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        break;
                }

                // execute the query (in this case add a new postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        public void UPDATE_OTHERS(Int32 _menuOption)
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            string query = "";
            switch (_menuOption)
            {
                case 3:     // colors
                    query = "UPDATE coloring SET coloringabr=@field1, coloringname=@field2, coloringdesc=@field3 WHERE coloringid=@oID";
                    break;
                case 4:     // conditions
                    query = "UPDATE cond SET condabr=@field1, condname=@field2, conddesc=@field3 WHERE condid=@oID";
                    break;
                case 5:     // countries
                    query = "UPDATE countries SET countryname=@field1, countryiso=@field2, countryculture=@field3, countrylang=@field4, countrydesc=@field5 WHERE countryid=@oID";
                    break;
                case 6:     // image type
                    query = "UPDATE imgtype SET imgtypeabr=@field1, imgtypename=@field2, imgtypedesc=@field3 WHERE imgtypeid=@oID";
                    break;
                case 7:     // materials
                    query = "UPDATE material SET materialname=@field1, materialdesc=@field2 WHERE materialid=@oID";
                    break;
                case 8:     // orientation
                    query = "UPDATE orient SET orientabr=@field1, orientname=@field2, orientdesc=@field3 WHERE orientid=@oID";
                    break;
                case 9:     // publishers
                    query = "UPDATE publishers SET publisher=@field1, publishcompanies=@field2, publishabr=@field3, publishdesc=@field4 WHERE publishid=@oID";
                    break;
                case 10:    // sent types
                    query = "UPDATE senttype SET senttypename=@field1, senttypedesc=@field2 WHERE senttypeid=@oID";
                    break;
                case 11:    // shapes
                    query = "UPDATE shape SET shapename=@field1, shapedesc=@field2 WHERE shapeid=@oID";
                    break;
                case 12:    // sizes
                    query = "UPDATE size SET sizename=@field1, sizedesc=@field2 WHERE sizeid=@oID";
                    break;
                case 13:    // themes
                    query = "UPDATE themes SET themename=@field1, themedesc=@field2 WHERE themeid=@oID";
                    break;
                case 14:    // years
                    query = "UPDATE yyear SET yearnumber=@field1 WHERE yearid=@oID";
                    break;
                case 15:    // languages
                    query = "UPDATE langtable SET langcountry=@field1, langculture=@field2 WHERE langtableid=@oID";
                    break;
                case 16:    // labels by language
                    query = "UPDATE applang SET langsoft=@field1, langculture=@field2, langdesc=@field3, applangid=@field4, langlongdesc=@field5 WHERE langid=@oID";
                    break;
            }
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                // add app fields data to the database fields
                switch (_menuOption)
                {
                    case 3:
                    case 4:
                    case 6:
                    case 8:
                    case 9:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = fieldData3[0];
                        break;
                    case 5:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = fieldData3[0];
                        cmd.Parameters.Add("@field4", MySqlDbType.VarChar).Value = fieldData4[0];
                        cmd.Parameters.Add("@field5", MySqlDbType.VarChar).Value = fieldData5[0];
                        break;
                    case 16:
                        cmd.Parameters.Add("@field1", MySqlDbType.Int32).Value = fieldData6;
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = fieldData3[0];
                        cmd.Parameters.Add("@field4", MySqlDbType.Int32).Value = fieldData7;
                        cmd.Parameters.Add("@field5", MySqlDbType.VarChar).Value = fieldData5[0];
                        break;
                    case 7:
                    case 10:
                    case 11:
                    case 12:
                    case 13:
                    case 15:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = fieldData2[0];
                        break;
                    case 14:
                        cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = fieldData1[0];
                        break;
                }
                // WHERE clause
                cmd.Parameters.Add("@oID", MySqlDbType.Int32).Value = othersID;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }

        public void DELETE_OTHER_TABLES(Int32 _tableOption)
        {
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            //
            connectdb.Close();
        }



        // *******************************************************************************************************
        // * 
        // *  Export data
        // * 
        // * *****************************************************************************************************
        public void showTables(string searchText, string requestedOrder, int _mOption)
        {
            string query = "";
            switch (_mOption)
            {
                case 1:     // postcards
                    query = "SELECT cardnumber, cardpublisher, cardsubpub, cardscanned, cardintheblog, cardblogurl, cardlocality, cardregion, cardregcountry, cardcountryname, carddesceng, carddescoriginal, cardthemename, cardcoloringabr, cardyearnumber, cardimgtype, cardimgnmbr, cardseriesmulti, cardsizename, cardshapename, cardorientabr, cardbarcode, cardmaterial, cardcondabr, cardborders, cardtxtfront, cardtxtback, cardfronttxtcolor, cardbacktxtcolor, carddatepurchased, cardcostprice, cardwebpage, cardidentical, cardequalsto, carddifferences, cardequalsto2, carddifferences2, cardequalsto3, carddifferences3, cardequalsto4, carddifferences4, cardequalsto5, carddifferences5, cardbigdesc, cardsenttypename, cardtypedesc, cardfrontimgpath, cardbackimgpath, cardregtime FROM card WHERE CONCAT_WS(' ', cardnumber, cardsubpub, cardcountryname, carddesceng, carddescoriginal, cardthemename) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                    break;
                case 2:     // series
                    query = "SELECT seriescardnumber, seriesseccardnumber, seriesdesceng, seriesdescoriginal, seriescolorabr, seriesorientabr, seriesimgcount, seriesdate, seriesyearnumber, seriesbarcode, seriesfronttxt, seriesbacktxt, seriesfronttxtcolor, seriesbacktxtcolor, seriesbigdesc, seriesfrontimgpath, seriesbackimgpath, seriesregtime FROM cardseries WHERE CONCAT_WS(' ', seriescardnumber, seriesseccardnumber, seriesdesceng, seriesdescoriginal) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                    break;
                case 3:     // colors
                    query = "SELECT coloringid, coloringabr, coloringname, coloringdesc FROM coloring WHERE CONCAT_WS(' ', coloringid, coloringabr, coloringname, coloringdesc) LIKE '%" + searchText + "%'";
                    break;
                case 4:     // conditions
                    query = "SELECT condid, condabr, condname, conddesc FROM cond WHERE CONCAT_WS(' ', condid, condabr, condname, conddesc) LIKE '%" + searchText + "%'";
                    break;
                case 5:     // countries
                    query = "SELECT countryid, countryname, countryiso, countrycuture, countrylang, countrydesc FROM countries  WHERE CONCAT_WS(' ', countryid, countryname, countryiso, countrylang, countrydesc) LIKE '%" + searchText + "%'";
                    break;
                case 6:     // image type
                    query = "SELECT imgtypeid, imgtypeabr, imgtypename, imgtypedesc FROM imgtype WHERE CONCAT_WS(' ', imgtypeid, imgtypeabr, imgtypename, imgtypedesc) LIKE '%" + searchText + "%'";
                    break;
                case 7:     // materials
                    query = "SELECT materialid, materialname, materialdesc FROM material WHERE CONCAT_WS(' ', materialid, materialname, materialdesc) LIKE '%" + searchText + "%'";
                    break;
                case 8:     // orientation
                    query = "SELECT orientid, orientabr, orientname, orientdesc FROM orient WHERE CONCAT_WS(' ', orientid, orientabr, oritentname, orientdesc) LIKE '%" + searchText + "%'";
                    break;
                case 9:     // publishers
                    query = "SELECT publishid, publisher, publishcompanies, publishdesc FROM publishers WHERE CONCAT_WS(' ', publishid, publisher, publishcompanies, publishdesc) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                    break;
                case 10:    // sent types
                    query = "SELECT senttypeid, senttypename, senttypedesc FROM senttype WHERE CONCAT_WS(' ', senttypeid, senttypename, senttypedesc) LIKE '%" + searchText + "%'";
                    break;
                case 11:    // shapes
                    query = "SELECT shapeid, shapename, shapedesc FROM shape WHERE CONCAT_WS(' ', shapeid, shapename, shapedesc) LIKE '%" + searchText + "%'";
                    break;
                case 12:    // sizes
                    query = "SELECT sizeid, sizename, sizedesc FROM size WHERE CONCAT_WS(' ', sizeid, sizename, sizedesc) LIKE '%" + searchText + "%'";
                    break;
                case 13:    // themes
                    query = "SELECT themeid, themename, themedesc FROM themes WHERE CONCAT_WS(' ', themeid, themename, themedesc) LIKE '%" + searchText + "%' ORDER BY " + requestedOrder;
                    break;
                case 14:    // years
                    query = "SELECT yearid, yearnumber FROM yyear ORDER BY " + requestedOrder;
                    break;
                case 15:    // languages
                    query = "SELECT langtableid, langcountry, langculture FROM langtable WHERE CONCAT_WS(' ', langtableid, langcountry, langculture) LIKE '%" + searchText + "%'";
                    break;
                case 16:    // labels by language
                    query = "SELECT langid, langsoft, langculture, langdesc, applangid, langlongdesc FROM applang WHERE CONCAT_WS(' ', langid, langsoft, langculture, langdesc, applangid, langlongdesc) LIKE '%" + searchText + "%'";
                    break;
            }
            try
            {
                connectdb.Close();

                connectdb.Open();
                DS = new DataSet();
                DT.Clear();
                MySqlDataAdapter DA = new MySqlDataAdapter(query, connectdb);
                DA.Fill(DS);
                DT = DS.Tables[0];
            }
            catch
            {

            }
        }



        // *******************************************************************************************************
        // * 
        // *  Update postcards date
        // * 
        // * *****************************************************************************************************
        public void UPDATE_FILE()
        {
            string _updTimeStamp, query;
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();
            query = "UPDATE cardsoft SET csoftudate=@field1"; // WHERE csofttype=@softtype
            _updTimeStamp = DateTime.Today.ToString("yyyy-MM-dd");

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = _updTimeStamp.Substring(0, 10);
                // WHERE clause
                //cmd.Parameters.Add("@softtype", MySqlDbType.Int32).Value = _softType;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
        }



        // *******************************************************************************************************
        // * 
        // *  Logs everything from all databases
        // * 
        // * *****************************************************************************************************
        public void ADD_LOG(string _softType, string _cardReferral, string _cardNum, string _oldDesc, string _newDesc, Int32 _uID)
        {
            // for future release to different users

            

            string query = "INSERT INTO logs(logtype, logreferral, logcard, logoldtext, lognewtext, loguid) VALUES(@field1, @field2, @field3, @field4, @field5, @field6)";
            if (connectdb.State != ConnectionState.Open)
                connectdb.Open();

            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connectdb;

                cmd.Parameters.Add("@field1", MySqlDbType.VarChar).Value = _softType;
                cmd.Parameters.Add("@field2", MySqlDbType.VarChar).Value = _cardReferral;
                cmd.Parameters.Add("@field3", MySqlDbType.VarChar).Value = _cardNum;
                cmd.Parameters.Add("@field4", MySqlDbType.LongText).Value = _oldDesc;
                cmd.Parameters.Add("@field5", MySqlDbType.LongText).Value = _newDesc;
                cmd.Parameters.Add("@field6", MySqlDbType.Int32).Value = _uID;

                // execute the query (in this case update the current postcard)
                cmd.ExecuteNonQuery();
                connectdb.Close();
            }
            
        }

    }
}
