<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="WEvents4ALL.registro"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<div id="registro" class="reg" style="height: 475px" >

<script type="text/javascript">

    var progreso = 1;
    var pasos = 0;

    function mostrar() {

        var doc1 = document.getElementById("PanelNombre");
        var doc2 = document.getElementById("Paises");
        var doc3 = document.getElementById("PanelDatosPersonales");
        var doc4 = document.getElementById("boton_enviarDatos");

        //doc.style.visibility = "hidden";
        doc1.style.display = "none";
        doc2.style.display = "none";
        doc3.style.display = "none";
        doc4.style.display = "none";



        //alert('Estas dentro del Javascript');

    }

    function siguientePaso() {

        var doc1 = document.getElementById("PanelNombre");
        var doc2 = document.getElementById("PanelUsuario");
        var doc3 = document.getElementById("Paises");
        var doc4 = document.getElementById("PanelDatosPersonales");
        var doc5 = document.getElementById("boton_enviarDatos");
        var doc6 = document.getElementById("progress-count");
        var doc7 = document.getElementById("boton_siguiente");
        progreso = progreso + 10;

        if (pasos == 0) {
            doc1.style.display = "block";
            doc2.style.display = "none";
            doc5.style.display = "none";
            doc6.style.width = progreso + "%";
            pasos = 1;
        }

        else if (pasos == 1) {
            doc1.style.display = "none";
            doc2.style.display = "none";
            doc3.style.display = "block";
            doc6.style.width = progreso + "%";
            pasos = 2;
            //alert("Entraste en Pasos 1");
        }

        else if (pasos == 2) {
            doc3.style.display = "none";
            doc4.style.display = "block";
            doc5.style.display = "block";
            doc7.style.display = "none";
            doc6.style.width = progreso + "%";
            //alert("Entraste en Pasos 2");
        }
        
    }

    window.onload = mostrar;

    

    </script>

    <fieldset style="height: 384px; width: 964px">
        
        <div class="barraProceso" >
            <div id="progress-count" style="width: 1%;" ></div>

        </div>

       <!-- <form id="registroUsuario" onsubmit="return false;" method="post" action="registro.aspx"> -->
        <div id="PanelNombre" >
            <label for="nombre">Nombre:</label>
            <!-- <input type="text" name="nom" id="nombre" size="20" maxlength="30" /> -->
            <asp:TextBox ID="textbox_nombreC" runat="server" />

            <label for="apellidos">Apellidos:</label>
            <!-- <input type="text"" name="apell" id="apellidos" size="40" maxlength="40" /> -->
            <asp:TextBox ID="textbox_apellidosC" runat="server" />

            <label for="NIF">NIF:</label>
            <!-- <input type="text" name="nif" id="NIF" size="10" maxlength="9" /> -->
            <asp:TextBox ID="textbox_NIFC" runat="server" />

            <label for="email">Email:</label>
            <!-- <input type="text" name="correo" id="email" size="40" maxlength="30"  /> -->
            <asp:TextBox ID="textbox_emailC" runat="server" />

            <label for="fechaN">Fecha Nac:</label>
            <!-- <input type="text" name="fechaNac" id="fechaN" size="18" /> -->
            <asp:TextBox ID="textbox_fechaN" runat="server" />
        </div>
        

        <div id="PanelUsuario" >
            <label for="usuario">Usuario:</label>
            <!-- <input type="text" name="user" id="usuario" size="20" maxlength="30" /> -->
            <asp:TextBox ID="textbox_usuario" runat="server" />

            <label for="password">Pass:</label>
            <!-- <input type="password" name="pass" id="password" size="22" maxlength="30" /> -->
            <asp:TextBox ID="textbox_pass" runat="server" />

            <label for="repetirPassword">Repite Pass:</label>
            <!-- <input type="password" name="passR" id="repetirPassword" size="22" maxlength="30" /> -->
            <asp:TextBox ID="textbox_rePass" runat="server" />
       </div>

        <br />


        <div id="Paises" >
            <label for="pais">Pais:</label>
           <!-- <select name="country" id="pais">
                <option value="España">España</option>
                <option value="Alemania">Alemania</option>
                <option value="Francia">Francia</option>
                <option value="EEUU">Estados Unidos</option>
            </select> -->
            <asp:DropDownList ID="DropDownList_Pais" runat="server" CssClass="datos_entrada">
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

            <label for="provincia">Provincia:</label>
            <!-- <select name="provin" id="provincia">
                <option value="Valencia">Valencia</option>
                <option value="Alicante">Alicante</option>
                <option value="Castellon">Castellon</option>
            </select> -->
            <asp:DropDownList ID="DropDownList_Prov" runat="server" CssClass="datos_entrada" >
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

            <label for="localidad">Localidad:</label>
            <!-- <select name="locali" id="localidad">
                <option value="San Vicente del Raspeig">San Vicente del Raspeig</option>
                <option value="Elda">Elda</option>
                <option value="Elche">Elche</option>
                <option value="Alicante">Alicante</option>
            </select> -->
            <asp:TextBox ID="textbox_localidadC" runat="server" />
        </div>

        <br />


        <div id="PanelDatosPersonales" >

            <div class="direccion">

                <label for="domicilio">Domicilio:</label>
                <!-- <input type="text" name="domici" id="domicilio" size="40" maxlength="40" /> -->
                <asp:TextBox ID="textbox_domicilioC" runat="server" />

                <label for="CP">Código Postal:</label>
                <!-- <input type="text" name="cp" id="codigoP" /> -->
                <asp:TextBox ID="textbox_CodigoPostalC" runat="server" />

                <br />
                <br />

            </div>
            <div class="telefonos">       
                <label for="telefono">Telefono:</label>
                <!-- <input type="text" name="tlf" id="telefono" size="14" maxlength="9" /> -->
                <asp:TextBox ID="textbox_telefonoC" runat="server" />

                <label for="movil">Movil:</label>
                <!-- <input type="text" name="mvl" id="movil" size="14" maxlength="9" /> -->
                <asp:TextBox ID="textbox_movilC" runat="server" />
            </div>

            <br />
            
            <label for="sexo">Sexo:</label>
            <asp:DropDownList ID="DropDownList_Sexo" runat="server" CssClass="datos_entrada" >
                 <asp:ListItem></asp:ListItem>
	             <asp:ListItem>Hombre</asp:ListItem>
                 <asp:ListItem>Mujer</asp:ListItem> 
            </asp:DropDownList>
            <!-- <label for="hombre">Hombre</label>
            <input type="radio" name="sexo" value="Hombre" id="hombre" />

            <br />

            <label for="mujer">Mujer</label>
            <input type="radio" name="sexo" value="Mujer" id="mujer" /> -->

            <br />
        </div>

       <div id="boton_enviarDatos" > 

            <!-- input type="submit" value="Enviar" onclick="Registro_Cliente" /> -->
            <asp:Button CssClass="btn btn-primary" ID="bGuardar" runat="server" 
                                    Text="Guardar Cambios" onclick="Registro_Cliente" />

       </div>

      <!-- </form> -->

      <div id="boton_siguiente" > 
       <button id="siguiente" type="button" onclick="siguientePaso()" style="">Siguiente</button>
       </div>

    </fieldset>


</asp:Content>
