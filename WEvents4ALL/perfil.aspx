<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" %>
<!--<link rel="stylesheet" type="text/css" href="/css/estilos.css" media="screen" />-->
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<div id="perfil" style="height: 360px">
    <form id="perfil" action="mi_funcion_de_guardado()">
    
        <label>Fotograf&iacute;a :</label>
        <br />
	    <img class="foto_usuario" src="/img/foto_usuario_defecto.jpg" alt="Elige imagen"/>
        <br/>
        <label>(Tama&ntilde;o m&aacute;ximo 50KB)</label>
        <br/>
	    <input type="file" name="foto_usuario" />

        <br />
        <table>
        <tr>
        <td><label>Nombre :</label></td>
        <td><input type="text" name="nombre1" id="nombre" size="20"/></td>
        </tr>
        <br/>
	   
        <label>Apellidos :</label>&nbsp;
        <input type="text" name="apellido" id="apellido"/><br />

        <label>NIF :</label>
        <input type="text" name="nombre" id="dni"/><br />
        
        <label>Fecha de nacimiento</label>
	    <select id="dianacimiento" name="dianacimiento">
	        <option  value="0"></option>
            <option  value="1">1</option>
            <option  value="2">2</option>
            <option  value="3">3</option>
            <option  value="4">4</option>
            <option  value="5">5</option>
            <option  value="6">6</option>
            <option  value="7">7</option>
            <option  value="8">8</option>
            <option  value="9">9</option>
            <option  value="10">10</option>
            <option  value="11">11</option>
            <option  value="12">12</option>
            <option  value="13">13</option>
            <option  value="14">14</option>
            <option  value="15">15</option>
            <option  value="16">16</option>
            <option  value="17">17</option>
            <option  value="18">18</option>
            <option  value="19">19</option>
            <option  value="20">20</option>
            <option  value="21">21</option>
            <option  value="22">22</option>
            <option  value="23">23</option>
            <option  value="24">24</option>
            <option  value="25">25</option>
            <option  value="26">26</option>
            <option  value="27">27</option>
            <option  value="28">28</option>
            <option  value="29">29</option>
            <option  value="30">30</option>
            <option  value="31">31</option>
        </select>
        <select id="mesnacimiento" name="mesnacimiento">
	        <option  value="0"¡></option>
		    <option  value="1">Enero</option>
		    <option  value="2">Febrero</option>
		    <option  value="3">Marzo</option>
		    <option  value="4">Abril</option>
		    <option  value="5">Mayo</option>
		    <option  value="6">Junio</option>
		    <option  value="7">Julio</option>
		    <option  value="8">Agosto</option>
		    <option  value="9">Septiembre</option>
		    <option  value="10">Octubre</option>
		    <option  value="11">Noviembre</option>
		    <option  value="12">Diciembre</option>
	    </select>
        <select id="anyonacimiento" name="anyonacimiento" >
	        <option  value="1900">1900</option>
		    <option  value="1901">1901</option>
		    <option  value="1902">1902</option>
		    <option  value="1903">1903</option>
		    <option  value="1904">1904</option>
		    <option  value="1905">1905</option>
						<option  value="1906">1906</option>
						<option  value="1907">1907</option>
						<option  value="1908">1908</option>
						<option  value="1909">1909</option>
						<option  value="1910">1910</option>	
						<option  value="1911">1911</option>
						<option  value="1912">1912</option>
						<option  value="1913">1913</option>
						<option  value="1914">1914</option>
						<option  value="1915">1915</option>
						<option  value="1916">1916</option>
						<option  value="1917">1917</option>
						<option  value="1918">1918</option>
						<option  value="1919">1919</option>
						<option  value="1920">1920</option>
						<option  value="1921">1921</option>
						<option  value="1922">1922</option>
						<option  value="1923">1923</option>
						<option  value="1924">1924</option>
						<option  value="1925">1925</option>
						<option  value="1926">1926</option>
						<option  value="1927">1927</option>
						<option  value="1928">1928</option>
						<option  value="1929">1929</option>
						<option  value="1930">1930</option>
						<option  value="1931">1931</option>
						<option  value="1932">1932</option>
						<option  value="1933">1933</option>
						<option  value="1934">1934</option>
						<option  value="1935">1935</option>
						<option  value="1936">1936</option>
						<option  value="1937">1937</option>
						<option  value="1938">1938</option>
						<option  value="1939">1939</option>
						<option  value="1940">1940</option>
						<option  value="1941">1941</option>
						<option  value="1942">1942</option>
						<option  value="1943">1943</option>
						<option  value="1944">1944</option>
						<option  value="1945">1945</option>
						<option  value="1946">1946</option>
						<option  value="1947">1947</option>
						<option  value="1948">1948</option>
						<option  value="1949">1949</option>
						<option  value="1950">1950</option>
						<option  value="1951">1951</option>
						<option  value="1952">1952</option>
						<option  value="1953">1953</option>
						<option  value="1954">1954</option>
						<option  value="1955">1955</option>
						<option  value="1956">1956</option>
						<option  value="1957">1957</option>
						<option  value="1958">1958</option>
						<option  value="1959">1959</option>
						<option  value="1960">1960</option>
						<option  value="1961">1961</option>
						<option  value="1962">1962</option>
						<option  value="1963">1963</option>
						<option  value="1964">1964</option>
						<option  value="1965">1965</option>
						<option  value="1966">1966</option>
						<option  value="1967">1967</option>
						<option  value="1968">1968</option>
						<option  value="1969">1969</option>
						<option  value="1970">1970</option>
						<option  value="1971">1971</option>
						<option  value="1972">1972</option>
						<option  value="1973">1973</option>
						<option  value="1974">1974</option>
						<option  value="1975">1975</option>
						<option  value="1976">1976</option>
						<option  value="1977">1977</option>
						<option  value="1978">1978</option>
						<option  value="1979">1979</option>
						<option  value="1980">1980</option>
						<option  value="1981">1981</option>
						<option  value="1982">1982</option>
						<option  value="1983">1983</option>
						<option  value="1984">1984</option>
						<option  value="1985">1985</option>
						<option  value="1986">1986</option>
						<option  value="1987">1987</option>
						<option  value="1988">1988</option>
						<option  value="1989">1989</option>
						<option  value="1990">1990</option>
						<option  value="1991">1991</option>
						<option  value="1992">1992</option>
						<option  value="1993">1993</option>
						<option  value="1994">1994</option>
						<option  value="1995">1995</option>
						<option  value="1996">1996</option>
						<option  value="1997">1997</option>
						<option  value="1998">1998</option>
						<option  value="1999">1999</option>
						<option  value="2000">2000</option>
						<option  value="2001">2001</option>
						<option  value="2002">2002</option>
						<option  value="2003">2003</option>
						<option  value="2004">2004</option>
						<option  value="2005">2005</option>
						<option  value="2006">2006</option>
						<option  value="2007">2007</option>
						<option  value="2008">2008</option>
						<option  value="2009">2009</option>
						<option  value="2010">2010</option>
						<option  value="2011">2011</option>
					</select>
        
        <br />

        <label>Pa&iacute;s de residencia :</label>
	    <select name="PAIS">
						<option value="PAIS_1" > Albania</option>
						<option value="PAIS_2" > Alemania</option>
						<option value="PAIS_3" > Argelia</option>
						<option value="PAIS_4" > Andorra</option>
						<option value="PAIS_5" > Angola</option>
						<option value="PAIS_6" > Anguila</option>
						<option value="PAIS_7" > Antigua y Barbuda</option>
						<option value="PAIS_8" > Antillas Holandesas</option>
						<option value="PAIS_9" > Arabia Saud&iacute;</option>
						<option value="PAIS_10" > Argentina</option>
						<option value="PAIS_11" > Armenia</option>
						<option value="PAIS_12" > Aruba</option>
						<option value="PAIS_13" > Australia</option>
						<option value="PAIS_14" > Austria</option>
						<option value="PAIS_15" > Azerbaiy&aacute;n</option>
						<option value="PAIS_16" > Bahamas</option>
						<option value="PAIS_17" > Bahrain</option>
						<option value="PAIS_18" > Bangladesh</option>
						<option value="PAIS_19" > Barbados</option>
						<option value="PAIS_20" > B&eacute;lgica</option>
						<option value="PAIS_21" > Belice</option>
						<option value="PAIS_22" > Ben&iacute;n</option>
						<option value="PAIS_23" > Bermuda</option>
						<option value="PAIS_24" > Bielorrusia</option>
						<option value="PAIS_25" > Birmania</option>
						<option value="PAIS_26" > But&aacute;n</option>
						<option value="PAIS_27" > Bolivia</option>
						<option value="PAIS_28" > Bosnia y Herzegovina</option>
						<option value="PAIS_29" > Botswana</option>
						<option value="PAIS_30" > Brasil</option>
						<option value="PAIS_31" > Brunei</option>
						<option value="PAIS_32" > Bulgaria</option>
						<option value="PAIS_33" > Burkina Faso</option>
						<option value="PAIS_34" > Burundi</option>
						<option value="PAIS_35" > Camboya</option>
						<option value="PAIS_36" > Camer&uacute;n</option>
						<option value="PAIS_37" > Canad&aacute;</option>
						<option value="PAIS_38" > Cabo Verde</option>
						<option value="PAIS_39" > Caim&aacute;n, Islas</option>
						<option value="PAIS_40" > Centroafricana, Rep&uacute;blica</option>
						<option value="PAIS_41" > Chad</option>
						<option value="PAIS_42" > Chile</option>
						<option value="PAIS_43" > China</option>
						<option value="PAIS_44" > Colombia</option>
						<option value="PAIS_45" > Comoras</option>
						<option value="PAIS_46" > Congo</option>
						<option value="PAIS_47" > Cook, Islas</option>
						<option value="PAIS_48" > Corea del Norte</option>
						<option value="PAIS_49" > Corea del Sur</option>
						<option value="PAIS_50" > Costa Rica</option>
						<option value="PAIS_51" > Costa de Marfil</option>
						<option value="PAIS_52" > Croacia</option>
						<option value="PAIS_53" > Cuba</option>
						<option value="PAIS_54" > Chipre</option>
						<option value="PAIS_55" > Checa Republica</option>
						<option value="PAIS_56" > Dinamarca</option>
						<option value="PAIS_57" > Djibouti</option>
						<option value="PAIS_58" > Dominica</option>
						<option value="PAIS_59" > Dominicana, Republica</option>
						<option value="PAIS_60" > Ecuador</option>
						<option value="PAIS_61" > Egipto</option>
						<option value="PAIS_62" > El Salvador</option>
						<option value="PAIS_63" > Emiratos &aacute;rabes Unidos</option>
						<option value="PAIS_64" > Eritrea</option>
						<option value="PAIS_65" > Eslovaquia</option>
						<option value="PAIS_66" > Eslovenia</option>
						<option value="PAIS_67" > España</option>
						<option value="PAIS_68" > EEUU</option>
						<option value="PAIS_69" > Estonia</option>
						<option value="PAIS_70" > Etiop&iacute;a</option>
						<option value="PAIS_71" > Feroe, Islas</option>
						<option value="PAIS_72" > Filipinas</option>
						<option value="PAIS_73" > Finlandia</option>
						<option value="PAIS_74" > Fiji</option>
						<option value="PAIS_75" > Francia</option>
						<option value="PAIS_76" > Gab&oacute;n</option>
						<option value="PAIS_77" > Gambia</option>
						<option value="PAIS_78" > Georgia</option>
						<option value="PAIS_79" > Ghana</option>
						<option value="PAIS_80" > Gibraltar</option>
						<option value="PAIS_81" > Granada</option>
						<option value="PAIS_82" > Grecia</option>
						<option value="PAIS_83" > Groenlandia</option>
						<option value="PAIS_84" > Guadalupe</option>
						<option value="PAIS_85" > Guatemala</option>
						<option value="PAIS_86" > Guinea</option>
						<option value="PAIS_87" > Guinea-Bissau</option>
						<option value="PAIS_88" > Guinea Ecuatorial</option>
						<option value="PAIS_89" > Guyana</option>
						<option value="PAIS_90" > Guayana Francesa</option>
						<option value="PAIS_91" > Hait&iacute;</option>
						<option value="PAIS_92" > Holanda</option>
						<option value="PAIS_93" > Honduras</option>
						<option value="PAIS_94" > Hong Kong</option>
						<option value="PAIS_95" > Hungr&iacute;a</option>
						<option value="PAIS_96" > India</option>
						<option value="PAIS_97" > Indonesia</option>
						<option value="PAIS_98" > Ir&aacute;n</option>
						<option value="PAIS_99" > Irlanda</option>
						<option value="PAIS_100" > Islandia</option>
						<option value="PAIS_101" > Israel</option>
						<option value="PAIS_102" > Italia</option>
						<option value="PAIS_103" > Jamaica</option>
						<option value="PAIS_104" > Jap&oacute;n</option>
						<option value="PAIS_105" > Jordania</option>
						<option value="PAIS_106" > Kazajist&aacute;n</option>
						<option value="PAIS_107" > Kenia</option>
						<option value="PAIS_108" > Kiribati</option>
						<option value="PAIS_109" > Kuwait</option>
						<option value="PAIS_110" > Kirguizist&aacute;n</option>
						<option value="PAIS_111" > Laos</option>
						<option value="PAIS_112" > Letonia</option>
						<option value="PAIS_113" > Lesotho</option>
						<option value="PAIS_114" > L&iacute;bano</option>
						<option value="PAIS_115" > Liberia</option>
						<option value="PAIS_116" > Libia</option>
						<option value="PAIS_117" > Liechtenstein</option>
						<option value="PAIS_118" > Lituania</option>
						<option value="PAIS_119" > Luxemburgo</option>
						<option value="PAIS_120" > Macedonia</option>
						<option value="PAIS_121" > Madagascar</option>
						<option value="PAIS_122" > Malawi</option>
						<option value="PAIS_123" > Malasia</option>
						<option value="PAIS_124" > Mal&iacute;</option>
						<option value="PAIS_125" > Malta</option>
						<option value="PAIS_126" > Marshall, Islas</option>
						<option value="PAIS_127" > Martinica</option>
						<option value="PAIS_128" > Mauritania</option>
						<option value="PAIS_129" > Mauricio</option>
						<option value="PAIS_130" > M&eacute;xico</option>
						<option value="PAIS_131" > Micronesia</option>
						<option value="PAIS_132" > Moldavia</option>
						<option value="PAIS_133" > M&oacute;naco</option>
						<option value="PAIS_134" > Mongolia</option>
						<option value="PAIS_135" > Montserrat</option>
						<option value="PAIS_136" > Marruecos</option>
						<option value="PAIS_137" > Mozambique</option>
						<option value="PAIS_138" > Namibia</option>
						<option value="PAIS_139" > Nauru</option>
						<option value="PAIS_140" > Nepal</option>
						<option value="PAIS_141" > Nueva Caledonia</option>
						<option value="PAIS_142" > Nueva Zelanda</option>
						<option value="PAIS_143" > Nicaragua</option>
						<option value="PAIS_144" > N&iacute;ger</option>
						<option value="PAIS_145" > Nigeria</option>
						<option value="PAIS_146" > Noruega</option>
						<option value="PAIS_147" > Om&aacute;n</option>
						<option value="PAIS_148" > Pakist&aacute;n</option>
						<option value="PAIS_149" > Palestina</option>
						<option value="PAIS_150" > Panam&aacute;</option>
						<option value="PAIS_151" > Pap&uacute;a-Nueva Guinea</option>
						<option value="PAIS_152" > Paraguay</option>
						<option value="PAIS_153" > Per&uacute;</option>
						<option value="PAIS_154" > Polonia</option>
						<option value="PAIS_155" > Portugal</option>
						<option value="PAIS_156" > Puerto Rico</option>
						<option value="PAIS_157" > Qatar</option>
						<option value="PAIS_158" > Reino Unido</option>
						<option value="PAIS_159" > Reuni&oacute;n</option>
						<option value="PAIS_160" > Ruanda</option>
						<option value="PAIS_161" > Rumania</option>
						<option value="PAIS_162" > Rusia</option>
						<option value="PAIS_163" > Sahara Occidental</option>
						<option value="PAIS_164" > San Kitts and Nevis</option>
						<option value="PAIS_165" > Santa Luc&iacute;a</option>
						<option value="PAIS_166" > San Vicente y Granadinas</option>
						<option value="PAIS_167" > Samoa</option>
						<option value="PAIS_168" > San Marino</option>
						<option value="PAIS_169" > Santo Tom&eacute; y Pr&iacute;ncipe</option>
						<option value="PAIS_170" > Senegal</option>
						<option value="PAIS_171" > Serbia y Montenegro</option>
						<option value="PAIS_172" > Seychelles</option>
						<option value="PAIS_173" > Sierra Leona</option>
						<option value="PAIS_174" > Singapur</option>
						<option value="PAIS_175" > Salom&oacute;n, Islas</option>
						<option value="PAIS_176" > Somalia</option>
						<option value="PAIS_177" > Sud&aacute;frica, Rep&uacute;blica de</option>
						<option value="PAIS_178" > Sri Lanka</option>
						<option value="PAIS_179" > Sudan</option>
						<option value="PAIS_180" > Suecia</option>
						<option value="PAIS_181" > Surinam</option>
						<option value="PAIS_182" > Suazilandia</option>
						<option value="PAIS_183" > Suiza</option>
						<option value="PAIS_184" > Siria</option>
						<option value="PAIS_185" > Tailandia</option>
						<option value="PAIS_186" > Taiw&aacute;n</option>
						<option value="PAIS_187" > Tanzania</option>
						<option value="PAIS_188" > Tayikist&aacute;n</option>
						<option value="PAIS_189" > Togo</option>
						<option value="PAIS_190" > Tonga</option>
						<option value="PAIS_191" > Trinidad y Tobago</option>
						<option value="PAIS_192" > T&uacute;nez</option>
						<option value="PAIS_193" > Turqu&iacute;a</option>
						<option value="PAIS_194" > Turkmenist&aacute;n</option>
						<option value="PAIS_195" > Tuvalu</option>
						<option value="PAIS_196" > Ucrania</option>
						<option value="PAIS_197" > Uganda</option>
						<option value="PAIS_198" > Uruguay</option>
						<option value="PAIS_199" > Uzbekist&aacute;n</option>
						<option value="PAIS_200" > Vanuatu</option>
						<option value="PAIS_201" > Vaticano</option>
						<option value="PAIS_202" > Venezuela</option>
						<option value="PAIS_203" > Vietnam</option>
						<option value="PAIS_204" > V&iacute;rgenes Islas</option>
						<option value="PAIS_205" > Yemen</option>
						<option value="PAIS_206" > Zaire</option>
						<option value="PAIS_207" > Zambia</option>
						<option value="PAIS_208" > Zimbabue</option>
	</select>

        <br />

        <label>Provincia :</label>&nbsp;
	    <select name="PAIS1">
			<option ></option>			
            <option value="Álava"> Álava</option>
            <option value="Albacete"> Albacete</option>
            <option value="Alicante"> Alicante</option>
            <option value="Almería"> Almería</option>
            <option value="Asturias"> Asturias</option>
            <option value="Avila"> Avila</option>
            <option value="Badajoz"> Badajoz</option>
            <option value="Barcelona"> Barcelona</option>
            <option value="Burgos"> Burgos</option>
            <option value="Cáceres"> Cáceres</option>
            <option value="Cádiz"> Cádiz</option>
            <option value="Cantabria"> Cantabria</option>
            <option value="Castellón"> Castellón</option>
            <option value="Ceuta"> Ceuta</option>
            <option value="Ciudad Real"> Ciudad Real</option>
            <option value="Córdoba"> Córdoba</option>
            <option value="Cuenca"> Cuenca</option>
            <option value="Gerona"> Gerona</option>
            <option value="Granada"> Granada</option>
            <option value="Guadalajara"> Guadalajara</option>
            <option value="Huelva"> Huelva</option>
            <option value="Huesca"> Huesca</option>
            <option value="Islas Baleares"> Islas Baleares</option>
            <option value="Jaén"> Jaén </option>
            <option value="La Coruña"> La Coruña</option>
            <option value="La Rioja"> La Rioja</option>
            <option value="Las Palmas"> Las Palmas</option>
            <option value="León"> León</option>
            <option value="Lérida"> Lérida</option>
            <option value="Lugo"> Lugo</option>
            <option value="Madrid"> Madrid</option>
            <option value="Málaga"> Málaga</option>
            <option value="Melilla"> Melilla</option>
            <option value="Murcia"> Murcia</option>
            <option value="Navarra"> Navarra</option>
            <option value="Orense"> Orense</option>
            <option value="Palencia"> Palencia</option>
            <option value="Pontevedra"> Pontevedra</option>
            <option value="S.C. De Tenerife"> S.C. De Tenerife</option>
            <option value="Salamanca"> Salamanca</option>
            <option value="Segovia"> Segovia</option>
            <option value="Sevilla"> Sevilla</option>
            <option value="Soria"> Soria</option>
            <option value="Tarragona"> Tarragona</option>
            <option value="Teruel"> Teruel</option>
            <option value="Toledo"> Toledo</option>
            <option value="Valencia"> Valencia</option>
            <option value="Valladolid"> Valladolid</option>
            <option value="Vizcaya"> Vizcaya</option>
            <option value="Zamora"> Zamora</option>
            <option value="Zaragoza"> Zaragoza</option>
	</select><br />

        <label>C&oacute;digo Postal :</label>
        <input type="text" name="cp" id="cp"/>

        <br />

        <label>Localidad :</label>
        <input type="text" name="localidad1" id="localidad" size="20"/>

        <br />

        <label>Domicilio :</label>
        <input type="text" name="localidad" id="Text1"/>

        <br />

        <label>Email:</label>
        <input type="text" name="mail1" id="mail" size="20"/>
        
        <br/>

        <label>Tel&eacute;fono :</label>
        <input type="text" name="tel1" id="tel1"/>
        
        <br/>

        <label>M&oacute;vil :</label>
        <input type="text" name="tel2" id="tel2"/>
        
        <br/>

        <label>Email:</label>
        <input type="text" name="mail" id="Text3"/>
        
        <br/>

        <label>Sexo:</label>
        <ul>
	        <li><input type="radio" name="sexo" id="hombre" value="S_MAN" checked="checked" />Hombre</li>
		    <li><input type="radio" name="sexo" id="mujer" value="S_WOMAN"/>Mujer</li>
	    </ul>

        <br />

        <label>Contrase&ntilde;a:</label>
        <input type="text" name="contrasenya" id="contrasenya"/>
        
        <br/>

        <label>Repita Contrase&ntilde;a:</label>
        <input type="text" name="contrasenya2" id="contrasenya2"/>
        
        <br/>

        <label>Nueva Contrase&ntilde;a:</label>
        <input type="text" name="contrasenya3" id="contrasenya3"/>
        
        <br/>
        
        
        <input class="botoncejo" type="submit" value="Enviar" />
        <input class="botoncejo" type="reset" value="Borrar" />
    </table>    
    </form>
</div>
<link rel="stylesheet" type="text/css" href="/css/perfil.css" media="screen" />
</asp:Content>
