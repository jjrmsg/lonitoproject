<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="WEvents4ALL.perfil"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<!--<link rel="stylesheet" type="text/css" href="/css/estilos.css" media="screen" />-->

<div id="perfil_general">
    <form id="perfil" action="">
    
        <div class="fotico">
	        <asp:Image ID="ImagePerfil" ImageUrl="/img/foto_usuario_defecto.jpg" runat="server" Width="200" Height="200"/>
            <br/>
            <asp:Label ID="Label_IntroFoto" runat="server" Text="(Tama&ntilde;o m&aacute;ximo 50KB)"></asp:Label>
            <br/>
	        <input type="file" name="foto_usuario" />
        </div>
        
        <div class="tablica">

        <asp:Table ID="datos" runat="server" BorderStyle="None" >

            <asp:TableRow runat="server" BorderStyle="None" CssClass="fila"> 
                
                <asp:TableCell ID="TableCell_11" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_Nombre" runat="server" Text="Nombre :" ></asp:Label>
                </asp:TableCell>


                <asp:TableCell ID="TableCell_12" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="nombre1" id="nombre" class="introduce_texto" value="Manolo" readonly="readonly" />
                </asp:TableCell>

                <asp:TableCell ID="TableCell_13" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_Apellido" runat="server" Text="Apellidos :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_14" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="apellido" id="apellido" class="introduce_texto" value="García Escobar" readonly="readonly"/>
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None" >
                <asp:TableCell ID="TableCell_21" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_NIF" runat="server" Text="NIF :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_22" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="nombre" id="dni" class="introduce_texto" value="59417626R" readonly="readonly"/>
                </asp:TableCell>

                <asp:TableCell ID="TableCell_23" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_FN" runat="server" Text="Fecha de nacimiento :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_24" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                     <asp:DropDownList ID="DropDownList_dia" runat="server" Width="38" Enabled=false>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                     </asp:DropDownList>
                     <asp:DropDownList ID="DropDownList_Mes" runat="server" Width="38" Enabled=false>
                         <asp:ListItem>9</asp:ListItem>
	                     <asp:ListItem></asp:ListItem> 
		                 <asp:ListItem>1</asp:ListItem> 
		                 <asp:ListItem>2</asp:ListItem> 
		                 <asp:ListItem>3</asp:ListItem> 
		                 <asp:ListItem>4</asp:ListItem> 
		                 <asp:ListItem>5</asp:ListItem> 
		                 <asp:ListItem>6</asp:ListItem> 
		                 <asp:ListItem>7</asp:ListItem> 
		                 <asp:ListItem>8</asp:ListItem> 
		                 <asp:ListItem>9</asp:ListItem> 
		                 <asp:ListItem>10</asp:ListItem> 
		                 <asp:ListItem>11</asp:ListItem> 
		                 <asp:ListItem>12</asp:ListItem> 
	                 </asp:DropDownList>
                     <asp:DropDownList ID="DropDownList_ano" runat="server" Width="54" Enabled=false>
                         <asp:ListItem>1931</asp:ListItem>
                         <asp:ListItem></asp:ListItem>
	                     <asp:ListItem>1900</asp:ListItem> 
		                 <asp:ListItem>1901</asp:ListItem> 
		                 <asp:ListItem>1902</asp:ListItem> 
		                 <asp:ListItem>1903</asp:ListItem> 
		                 <asp:ListItem>1904</asp:ListItem> 
		                 <asp:ListItem>1905</asp:ListItem> 
						 <asp:ListItem>1906</asp:ListItem> 
						 <asp:ListItem>1907</asp:ListItem> 
						 <asp:ListItem>1908</asp:ListItem> 
						 <asp:ListItem>1909</asp:ListItem> 
						 <asp:ListItem>1910</asp:ListItem> 	
						 <asp:ListItem>1911</asp:ListItem> 
						 <asp:ListItem>1912</asp:ListItem> 
						 <asp:ListItem>1913</asp:ListItem> 
						 <asp:ListItem>1914</asp:ListItem> 
						 <asp:ListItem>1915</asp:ListItem> 
						 <asp:ListItem>1916</asp:ListItem> 
						 <asp:ListItem>1917</asp:ListItem> 
						 <asp:ListItem>1918</asp:ListItem> 
						 <asp:ListItem>1919</asp:ListItem> 
						 <asp:ListItem>1920</asp:ListItem> 
						 <asp:ListItem>1921</asp:ListItem> 
						 <asp:ListItem>1922</asp:ListItem> 
						 <asp:ListItem>1923</asp:ListItem> 
						 <asp:ListItem>1924</asp:ListItem> 
						 <asp:ListItem>1925</asp:ListItem> 
						 <asp:ListItem>1926</asp:ListItem> 
						 <asp:ListItem>1927</asp:ListItem> 
						 <asp:ListItem>1928</asp:ListItem> 
						 <asp:ListItem>1929</asp:ListItem> 
						 <asp:ListItem>1930</asp:ListItem> 
						 <asp:ListItem>1931</asp:ListItem> 
						 <asp:ListItem>1932</asp:ListItem> 
						 <asp:ListItem>1933</asp:ListItem> 
						 <asp:ListItem>1934</asp:ListItem> 
						 <asp:ListItem>1935</asp:ListItem> 
						 <asp:ListItem>1936</asp:ListItem> 
						 <asp:ListItem>1937</asp:ListItem> 
						 <asp:ListItem>1938</asp:ListItem> 
						 <asp:ListItem>1939</asp:ListItem> 
						 <asp:ListItem>1940</asp:ListItem> 
						 <asp:ListItem>1941</asp:ListItem> 
						 <asp:ListItem>1942</asp:ListItem> 
						 <asp:ListItem>1943</asp:ListItem> 
						 <asp:ListItem>1944</asp:ListItem> 
						 <asp:ListItem>1945</asp:ListItem> 
						 <asp:ListItem>1946</asp:ListItem> 
						 <asp:ListItem>1947</asp:ListItem> 
						 <asp:ListItem>1948</asp:ListItem> 
						 <asp:ListItem>1949</asp:ListItem> 
						 <asp:ListItem>1950</asp:ListItem> 
						 <asp:ListItem>1951</asp:ListItem> 
						 <asp:ListItem>1952</asp:ListItem> 
						 <asp:ListItem>1953</asp:ListItem> 
						 <asp:ListItem>1954</asp:ListItem> 
						 <asp:ListItem>1955</asp:ListItem> 
						 <asp:ListItem>1956</asp:ListItem> 
						 <asp:ListItem>1957</asp:ListItem> 
						 <asp:ListItem>1958</asp:ListItem> 
						 <asp:ListItem>1959</asp:ListItem> 
						 <asp:ListItem>1960</asp:ListItem> 
						 <asp:ListItem>1961</asp:ListItem> 
						 <asp:ListItem>1962</asp:ListItem> 
						 <asp:ListItem>1963</asp:ListItem> 
						 <asp:ListItem>1964</asp:ListItem> 
						 <asp:ListItem>1965</asp:ListItem> 
						 <asp:ListItem>1966</asp:ListItem> 
						 <asp:ListItem>1967</asp:ListItem> 
						 <asp:ListItem>1968</asp:ListItem> 
						 <asp:ListItem>1969</asp:ListItem> 
						 <asp:ListItem>1970</asp:ListItem> 
						 <asp:ListItem>1971</asp:ListItem> 
						 <asp:ListItem>1972</asp:ListItem> 
						 <asp:ListItem>1973</asp:ListItem> 
						 <asp:ListItem>1974</asp:ListItem> 
						 <asp:ListItem>1975</asp:ListItem> 
						 <asp:ListItem>1976</asp:ListItem> 
						 <asp:ListItem>1977</asp:ListItem> 
						 <asp:ListItem>1978</asp:ListItem> 
						 <asp:ListItem>1979</asp:ListItem> 
						 <asp:ListItem>1980</asp:ListItem> 
						 <asp:ListItem>1981</asp:ListItem> 
						 <asp:ListItem>1982</asp:ListItem> 
						 <asp:ListItem>1983</asp:ListItem> 
						 <asp:ListItem>1984</asp:ListItem> 
						 <asp:ListItem>1985</asp:ListItem> 
						 <asp:ListItem>1986</asp:ListItem> 
						 <asp:ListItem>1987</asp:ListItem> 
						 <asp:ListItem>1988</asp:ListItem> 
						 <asp:ListItem>1989</asp:ListItem> 
						 <asp:ListItem>1990</asp:ListItem> 
						 <asp:ListItem>1991</asp:ListItem> 
						 <asp:ListItem>1992</asp:ListItem> 
						 <asp:ListItem>1993</asp:ListItem> 
						 <asp:ListItem>1994</asp:ListItem> 
						 <asp:ListItem>1995</asp:ListItem> 
						 <asp:ListItem>1996</asp:ListItem> 
						 <asp:ListItem>1997</asp:ListItem> 
						 <asp:ListItem>1998</asp:ListItem> 
						 <asp:ListItem>1999</asp:ListItem> 
						 <asp:ListItem>2000</asp:ListItem> 
						 <asp:ListItem>2001</asp:ListItem> 
						 <asp:ListItem>2002</asp:ListItem> 
						 <asp:ListItem>2003</asp:ListItem> 
						 <asp:ListItem>2004</asp:ListItem> 
						 <asp:ListItem>2005</asp:ListItem> 
						 <asp:ListItem>2006</asp:ListItem> 
						 <asp:ListItem>2007</asp:ListItem> 
						 <asp:ListItem>2008</asp:ListItem> 
						 <asp:ListItem>2009</asp:ListItem> 
						 <asp:ListItem>2010</asp:ListItem> 
						 <asp:ListItem>2011</asp:ListItem>
                         <asp:ListItem>2012</asp:ListItem> 
                         <asp:ListItem>2013</asp:ListItem> 
                         <asp:ListItem>2014</asp:ListItem> 
                         <asp:ListItem>2015</asp:ListItem> 
                         <asp:ListItem>2016</asp:ListItem> 
                         <asp:ListItem>2017</asp:ListItem> 
                         <asp:ListItem>2018</asp:ListItem>  
					 </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        
	        <asp:TableRow runat="server" BorderStyle="None"> 
                <asp:TableCell ID="TableCell_31" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_Pais" runat="server" Text="Pa&iacute;s de residencia :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_32" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <asp:DropDownList ID="DropDownList_Pais" runat="server" Enabled=false>
                        <asp:ListItem>España</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
						<asp:ListItem>Albania</asp:ListItem> 
						<asp:ListItem>Alemania</asp:ListItem> 
						<asp:ListItem>Argelia</asp:ListItem> 
						<asp:ListItem>Andorra</asp:ListItem> 
						<asp:ListItem>Angola</asp:ListItem> 
						<asp:ListItem>Anguila</asp:ListItem> 
						<asp:ListItem>Antigua y Barbuda</asp:ListItem> 
						<asp:ListItem>Antillas Holandesas</asp:ListItem> 
						<asp:ListItem>Arabia Saud&iacute;</asp:ListItem> 
						<asp:ListItem>Argentina</asp:ListItem> 
						<asp:ListItem>Armenia</asp:ListItem> 
						<asp:ListItem>Aruba</asp:ListItem> 
						<asp:ListItem>Australia</asp:ListItem> 
						<asp:ListItem>Austria</asp:ListItem> 
						<asp:ListItem>Azerbaiy&aacute;n</asp:ListItem> 
						<asp:ListItem>Bahamas</asp:ListItem> 
						<asp:ListItem>Bahrain</asp:ListItem> 
						<asp:ListItem>Bangladesh</asp:ListItem> 
						<asp:ListItem>Barbados</asp:ListItem> 
						<asp:ListItem>B&eacute;lgica</asp:ListItem> 
						<asp:ListItem>Belice</asp:ListItem> 
						<asp:ListItem>Ben&iacute;n</asp:ListItem> 
						<asp:ListItem>Bermuda</asp:ListItem> 
						<asp:ListItem>Bielorrusia</asp:ListItem> 
						<asp:ListItem>Birmania</asp:ListItem> 
						<asp:ListItem>But&aacute;n</asp:ListItem> 
						<asp:ListItem>Bolivia</asp:ListItem> 
						<asp:ListItem>Bosnia y Herzegovina</asp:ListItem> 
						<asp:ListItem>Botswana</asp:ListItem> 
						<asp:ListItem>Brasil</asp:ListItem> 
						<asp:ListItem>Brunei</asp:ListItem> 
						<asp:ListItem>Bulgaria</asp:ListItem> 
						<asp:ListItem>Burkina Faso</asp:ListItem> 
						<asp:ListItem>Burundi</asp:ListItem> 
						<asp:ListItem>Camboya</asp:ListItem> 
						<asp:ListItem>Camer&uacute;n</asp:ListItem> 
						<asp:ListItem>Canad&aacute;</asp:ListItem> 
						<asp:ListItem>Cabo Verde</asp:ListItem> 
						<asp:ListItem>Caim&aacute;n, Islas</asp:ListItem> 
						<asp:ListItem>Cetroafricana, Rep&uacute;blica</asp:ListItem>
						<asp:ListItem>Chad</asp:ListItem> 
						<asp:ListItem>Chile</asp:ListItem> 
						<asp:ListItem>China</asp:ListItem> 
						<asp:ListItem>Colombia</asp:ListItem> 
						<asp:ListItem>Comoras</asp:ListItem> 
						<asp:ListItem>Congo</asp:ListItem> 
						<asp:ListItem>Cook, Islas</asp:ListItem> 
						<asp:ListItem>Corea del Norte</asp:ListItem> 
						<asp:ListItem>Corea del Sur</asp:ListItem> 
						<asp:ListItem>Costa Rica</asp:ListItem> 
						<asp:ListItem>Costa de Marfil</asp:ListItem> 
						<asp:ListItem>Croacia</asp:ListItem> 
						<asp:ListItem>Cuba</asp:ListItem> 
						<asp:ListItem>Chipre</asp:ListItem> 
						<asp:ListItem>Checa Republica</asp:ListItem> 
						<asp:ListItem>Dinamarca</asp:ListItem> 
						<asp:ListItem>Djibouti</asp:ListItem> 
						<asp:ListItem>Dominica</asp:ListItem> 
						<asp:ListItem>Dominicana, Republica</asp:ListItem> 
						<asp:ListItem>Ecuador</asp:ListItem> 
						<asp:ListItem>Egipto</asp:ListItem> 
						<asp:ListItem>El Salvador</asp:ListItem> 
						<asp:ListItem>Emiratos &aacute;rabes Unidos</asp:ListItem> 
						<asp:ListItem>Eritrea</asp:ListItem>
						<asp:ListItem>Eslovaquia</asp:ListItem> 
						<asp:ListItem>Eslovenia</asp:ListItem> 
						<asp:ListItem>España</asp:ListItem> 
						<asp:ListItem>EEUU</asp:ListItem> 
						<asp:ListItem>Estonia</asp:ListItem> 
						<asp:ListItem>Etiop&iacute;a</asp:ListItem> 
						<asp:ListItem>Feroe, Islas</asp:ListItem> 
						<asp:ListItem>Filipinas</asp:ListItem> 
						<asp:ListItem>Finlandia</asp:ListItem> 
						<asp:ListItem>Fiji</asp:ListItem> 
						<asp:ListItem>Francia</asp:ListItem> 
						<asp:ListItem>Gab&oacute;n</asp:ListItem> 
						<asp:ListItem>Gambia</asp:ListItem> 
						<asp:ListItem>Georgia</asp:ListItem> 
						<asp:ListItem>Ghana</asp:ListItem> 
						<asp:ListItem>Gibraltar</asp:ListItem> 
						<asp:ListItem>Granada</asp:ListItem> 
						<asp:ListItem>Grecia</asp:ListItem> 
						<asp:ListItem>Groenlandia</asp:ListItem> 
						<asp:ListItem>Guadalupe</asp:ListItem> 
						<asp:ListItem>Guatemala</asp:ListItem> 
						<asp:ListItem>Guinea</asp:ListItem> 
						<asp:ListItem>Guinea-Bissau</asp:ListItem> 
						<asp:ListItem>Guinea Ecuatorial</asp:ListItem> 
						<asp:ListItem>Guyana</asp:ListItem> 
						<asp:ListItem>Guayana Francesa</asp:ListItem> 
						<asp:ListItem>Hait&iacute;</asp:ListItem> 
						<asp:ListItem>Holanda</asp:ListItem> 
						<asp:ListItem>Honduras</asp:ListItem> 
						<asp:ListItem>Hong Kong</asp:ListItem> 
						<asp:ListItem>Hungr&iacute;a</asp:ListItem> 
						<asp:ListItem>India</asp:ListItem> 
						<asp:ListItem>Indonesia</asp:ListItem> 
						<asp:ListItem>Ir&aacute;n</asp:ListItem> 
						<asp:ListItem>Irlanda</asp:ListItem> 
						<asp:ListItem>Islandia</asp:ListItem> 
						<asp:ListItem>Israel</asp:ListItem> 
						<asp:ListItem>Italia</asp:ListItem> 
						<asp:ListItem>Jamaica</asp:ListItem> 
						<asp:ListItem>Jap&oacute;n</asp:ListItem> 
						<asp:ListItem>Jordania</asp:ListItem> 
						<asp:ListItem>Kazajist&aacute;n</asp:ListItem> 
						<asp:ListItem>Kenia</asp:ListItem> 
						<asp:ListItem>Kiribati</asp:ListItem> 
						<asp:ListItem>Kuwait</asp:ListItem> 
						<asp:ListItem>Kirguizist&aacute;n</asp:ListItem> 
						<asp:ListItem>Laos</asp:ListItem> 
						<asp:ListItem>Letonia</asp:ListItem> 
						<asp:ListItem>Lesotho</asp:ListItem> 
						<asp:ListItem>L&iacute;bano</asp:ListItem> 
						<asp:ListItem>Liberia</asp:ListItem> 
						<asp:ListItem>Libia</asp:ListItem> 
						<asp:ListItem>Liechtenstein</asp:ListItem> 
						<asp:ListItem>Lituania</asp:ListItem> 
						<asp:ListItem>Luxemburgo</asp:ListItem> 
						<asp:ListItem>Macedonia</asp:ListItem> 
						<asp:ListItem>Madagascar</asp:ListItem> 
						<asp:ListItem>Malawi</asp:ListItem> 
						<asp:ListItem>Malasia</asp:ListItem> 
						<asp:ListItem>Mal&iacute;</asp:ListItem> 
						<asp:ListItem>Malta</asp:ListItem> 
						<asp:ListItem>Marshall, Islas</asp:ListItem> 
						<asp:ListItem>Martinica</asp:ListItem> 
						<asp:ListItem>Mauritania</asp:ListItem> 
						<asp:ListItem>Mauricio</asp:ListItem> 
						<asp:ListItem>M&eacute;xico</asp:ListItem> 
						<asp:ListItem>Micronesia</asp:ListItem> 
						<asp:ListItem>Moldavia</asp:ListItem> 
						<asp:ListItem>M&oacute;naco</asp:ListItem> 
						<asp:ListItem>Mongolia</asp:ListItem> 
						<asp:ListItem>Montserrat</asp:ListItem> 
						<asp:ListItem>Marruecos</asp:ListItem> 
						<asp:ListItem>Mozambique</asp:ListItem> 
						<asp:ListItem>Namibia</asp:ListItem> 
						<asp:ListItem>Nauru</asp:ListItem> 
						<asp:ListItem>Nepal</asp:ListItem> 
						<asp:ListItem>Nueva Caledonia</asp:ListItem> 
						<asp:ListItem>Nueva Zelanda</asp:ListItem> 
						<asp:ListItem>Nicaragua</asp:ListItem> 
						<asp:ListItem>N&iacute;ger</asp:ListItem> 
						<asp:ListItem>Nigeria</asp:ListItem> 
						<asp:ListItem>Noruega</asp:ListItem> 
						<asp:ListItem>Om&aacute;n</asp:ListItem> 
						<asp:ListItem>Pakist&aacute;n</asp:ListItem> 
						<asp:ListItem>Palestina</asp:ListItem> 
						<asp:ListItem>Panam&aacute;</asp:ListItem> 
						<asp:ListItem>Pap&uacute;a-Nueva Guinea</asp:ListItem> 
						<asp:ListItem>Paraguay</asp:ListItem> 
						<asp:ListItem>Per&uacute;</asp:ListItem> 
						<asp:ListItem>Polonia</asp:ListItem> 
						<asp:ListItem>Portugal</asp:ListItem> 
						<asp:ListItem>Puerto Rico</asp:ListItem> 
						<asp:ListItem>Qatar</asp:ListItem> 
						<asp:ListItem>Reino Unido</asp:ListItem> 
						<asp:ListItem>Reuni&oacute;n</asp:ListItem> 
						<asp:ListItem>Ruanda</asp:ListItem> 
						<asp:ListItem>Rumania</asp:ListItem> 
						<asp:ListItem>Rusia</asp:ListItem> 
						<asp:ListItem>Sahara Occidental</asp:ListItem> 
						<asp:ListItem>San Kitts and Nevis</asp:ListItem> 
						<asp:ListItem>Santa Luc&iacute;a</asp:ListItem> 
						<asp:ListItem>San Vicente y Granadinas</asp:ListItem> 
						<asp:ListItem>Samoa</asp:ListItem> 
						<asp:ListItem>San Marino</asp:ListItem> 
						<asp:ListItem>Santo Tom&eacute; y Pr&iacute;ncipe</asp:ListItem> 
						<asp:ListItem>Senegal</asp:ListItem> 
						<asp:ListItem>Serbia y Montenegro</asp:ListItem> 
						<asp:ListItem>Seychelles</asp:ListItem> 
						<asp:ListItem>Sierra Leona</asp:ListItem> 
						<asp:ListItem>Singapur</asp:ListItem> 
						<asp:ListItem>Salom&oacute;n, Islas</asp:ListItem> 
						<asp:ListItem>Somalia</asp:ListItem> 
						<asp:ListItem>Sud&aacute;frica, Rep&uacute;blica de</asp:ListItem> 
						<asp:ListItem>Sri Lanka</asp:ListItem> 
						<asp:ListItem>Sudan</asp:ListItem> 
						<asp:ListItem>Suecia</asp:ListItem> 
						<asp:ListItem>Surinam</asp:ListItem> 
						<asp:ListItem>Suazilandia</asp:ListItem> 
						<asp:ListItem>Suiza</asp:ListItem> 
						<asp:ListItem>Siria</asp:ListItem> 
						<asp:ListItem>Tailandia</asp:ListItem> 
						<asp:ListItem>Taiw&aacute;n</asp:ListItem> 
						<asp:ListItem>Tanzania</asp:ListItem> 
						<asp:ListItem>Tayikist&aacute;n</asp:ListItem> 
						<asp:ListItem>Togo</asp:ListItem> 
						<asp:ListItem>Tonga</asp:ListItem> 
						<asp:ListItem>Trinidad y Tobago</asp:ListItem> 
						<asp:ListItem>T&uacute;nez</asp:ListItem> 
						<asp:ListItem>Turqu&iacute;a</asp:ListItem> 
						<asp:ListItem>Turkmenist&aacute;n</asp:ListItem> 
						<asp:ListItem>Tuvalu</asp:ListItem> 
						<asp:ListItem>Ucrania</asp:ListItem> 
						<asp:ListItem>Uganda</asp:ListItem> 
						<asp:ListItem>Uruguay</asp:ListItem> 
						<asp:ListItem>Uzbekist&aacute;n</asp:ListItem> 
						<asp:ListItem>Vanuatu</asp:ListItem> 
						<asp:ListItem>Vaticano</asp:ListItem> 
						<asp:ListItem>Venezuela</asp:ListItem> 
						<asp:ListItem>Vietnam</asp:ListItem> 
						<asp:ListItem>V&iacute;rgenes Islas</asp:ListItem> 
						<asp:ListItem>Yemen</asp:ListItem> 
						<asp:ListItem>Zaire</asp:ListItem> 
						<asp:ListItem>Zambia</asp:ListItem> 
						<asp:ListItem>Zimbabue</asp:ListItem> 
	                </asp:DropDownList>
                </asp:TableCell>

                <asp:TableCell ID="TableCell_33" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_Prov" runat="server" Text="Provincia :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_34" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <asp:DropDownList ID="DropDownList_Prov" runat="server" Enabled=false>
                         <asp:ListItem>Almería</asp:ListItem>
			             <asp:ListItem></asp:ListItem> 			
                         <asp:ListItem>Álava</asp:ListItem>                     
                         <asp:ListItem>Albacete</asp:ListItem> 
                         <asp:ListItem>Alicante</asp:ListItem> 
                         <asp:ListItem>Almería</asp:ListItem> 
                         <asp:ListItem>Asturias</asp:ListItem> 
                         <asp:ListItem>Avila</asp:ListItem> 
                         <asp:ListItem>Badajoz</asp:ListItem> 
                         <asp:ListItem>Barcelona</asp:ListItem> 
                         <asp:ListItem>Burgos</asp:ListItem> 
                         <asp:ListItem>Cáceres</asp:ListItem> 
                         <asp:ListItem>Cádiz</asp:ListItem> 
                         <asp:ListItem>Cantabria</asp:ListItem> 
                         <asp:ListItem>Castellón</asp:ListItem> 
                         <asp:ListItem>Ceuta</asp:ListItem> 
                         <asp:ListItem>Ciudad Real</asp:ListItem> 
                         <asp:ListItem>Córdoba</asp:ListItem> 
                         <asp:ListItem>Cuenca</asp:ListItem> 
                         <asp:ListItem>Gerona</asp:ListItem> 
                         <asp:ListItem>Granada</asp:ListItem> 
                         <asp:ListItem>Guadalajara</asp:ListItem> 
                         <asp:ListItem>Huelva</asp:ListItem> 
                         <asp:ListItem>Huesca</asp:ListItem> 
                         <asp:ListItem>Islas Baleares</asp:ListItem> 
                         <asp:ListItem>Jaén </asp:ListItem> 
                         <asp:ListItem>La Coruña</asp:ListItem> 
                         <asp:ListItem>La Rioja</asp:ListItem> 
                         <asp:ListItem>Las Palmas</asp:ListItem> 
                         <asp:ListItem>León</asp:ListItem> 
                         <asp:ListItem>Lérida</asp:ListItem> 
                         <asp:ListItem>Lugo</asp:ListItem> 
                         <asp:ListItem>Madrid</asp:ListItem> 
                         <asp:ListItem>Málaga</asp:ListItem> 
                         <asp:ListItem>Melilla</asp:ListItem> 
                         <asp:ListItem>Murcia</asp:ListItem> 
                         <asp:ListItem>Navarra</asp:ListItem> 
                         <asp:ListItem>Orense</asp:ListItem> 
                         <asp:ListItem>Palencia</asp:ListItem> 
                         <asp:ListItem>Pontevedra</asp:ListItem> 
                         <asp:ListItem>S.C. De Tenerife</asp:ListItem> 
                         <asp:ListItem>Salamanca</asp:ListItem> 
                         <asp:ListItem>Segovia</asp:ListItem> 
                         <asp:ListItem>Sevilla</asp:ListItem> 
                         <asp:ListItem>Soria</asp:ListItem> 
                         <asp:ListItem>Tarragona</asp:ListItem> 
                         <asp:ListItem>Teruel</asp:ListItem> 
                         <asp:ListItem>Toledo</asp:ListItem> 
                         <asp:ListItem>Valencia</asp:ListItem> 
                         <asp:ListItem>Valladolid</asp:ListItem> 
                         <asp:ListItem>Vizcaya</asp:ListItem> 
                         <asp:ListItem>Zamora</asp:ListItem> 
                         <asp:ListItem>Zaragoza</asp:ListItem> 
                     </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None">
                <asp:TableCell ID="TableCell_41" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_CP" runat="server" Text="C&oacute;digo Postal :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_42" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="cp" id="cp" class="introduce_texto" value="96472" readonly="readonly"/>
                </asp:TableCell>

                <asp:TableCell ID="TableCell_43" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_Local" runat="server" Text="Localidad :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_44" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="localidad1" id="localidad" class="introduce_texto" value="Almería" readonly="readonly"/>
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None">
                <asp:TableCell ID="TableCell_51" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_Dom" runat="server" Text="Domicilio :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_52" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="domicilo" id="dom" class="introduce_texto" value="Ave. Del Gitanillo Nº82" readonly="readonly"/>
                </asp:TableCell>

                <asp:TableCell ID="TableCell_53" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                <asp:Label ID="Label_Mail" runat="server" Text="Email:" ></asp:Label>
                    </asp:TableCell>
                <asp:TableCell ID="TableCell_54" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="mail1" id="mail" class="introduce_texto" value="micarro@melorobaron.com" readonly="readonly"/>
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None">
                <asp:TableCell ID="TableCell_61" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_tel1" runat="server" Text="Tel&eacute;fono :"></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_62" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="tel1" id="tel1" class="introduce_texto" value="966 317865" readonly="readonly"/>
                </asp:TableCell>

                <asp:TableCell ID="TableCell_63" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_tel2" runat="server" Text="M&oacute;vil :"></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_64" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="tel2" id="tel2" class="introduce_texto" value="680 658876" readonly="readonly"/>
                </asp:TableCell>
            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None">
                <asp:TableCell ID="TableCell_71" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_sexo" runat="server" Text="Sexo:" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_72" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
	                 <asp:DropDownList ID="DropDownList_Sexo" runat="server" Enabled=false>
	                     <asp:ListItem>Hombre</asp:ListItem>
                         <asp:ListItem>Mujer</asp:ListItem>   
                    </asp:DropDownList>
	            </asp:TableCell>

                
            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None">
                <asp:TableCell ID="TableCell_81" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_pass3" runat="server" Text="Nueva Contrase&ntilde;a :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_82" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="pass3" id="pass3" class="introduce_texto" readonly="readonly"/>
                </asp:TableCell>

            </asp:TableRow>
        
            <asp:TableRow runat="server" BorderStyle="None" >
                <asp:TableCell ID="TableCell_91" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_pass" runat="server" Text="Contrase&ntilde;a :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_92" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="pass" id="pass" class="introduce_texto" readonly="readonly"/></asp:TableCell>

                <asp:TableCell ID="TableCell_93" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="labels_perfil">
                    <asp:Label ID="Label_pass2" runat="server" Text="Repita Contrase&ntilde;a :" ></asp:Label>
                </asp:TableCell>
                <asp:TableCell ID="TableCell_94" runat="server" BorderStyle="None" HorizontalAlign="Left" CssClass="datos_perfil">
                    <input type="text" name="pass2" id="pass2" class="introduce_texto" readonly="readonly"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>    
        </div>

        <div class="Botones">
            <input class="botoncejo" type="submit" value="Enviar" />
            <input class="botoncejo" type="reset" value="Borrar" />
        </div>
    </form>

</div>
</asp:Content>
