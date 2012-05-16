<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="WEvents4ALL.perfil"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">
<div class="row">
    <div class="span10">  
        <!-- Pestañas de navegacion -->
        <ul class="nav nav-tabs" >
            <li class="active">
                <a href="#tabPerfil" data-toggle="tab">
                    <i class="icon-user"></i>
                    Perfil
                </a>
            </li>
            <li> 
                <a href="#tabCompras" data-toggle="tab">
                    <i class="icon-shopping-cart"></i>
                    Últimas Compras
                </a>
            </li>
        </ul>
        
        <!-- Contenido de cada pestaña -->
        <div class="tab-content">
        <!-- Pestaña Perfil --> 
            <div class="tab-pane active" id="tabPerfil">
                <div id="formulario" class="form-horizontal">
                    <!-- Datos Personales -->              
                    <fieldset class="form-horizontal">
                    <legend>Datos Personales</legend>
                        <br />
                        <!-- Seccion Foto --> 
                        <div class="span3" id="fotico">
                            <div class="thumbnail">
                                <img src="/img/foto_usuario_defecto.jpg" alt="Avatar del Usuario">
                                <div class="caption" id="botonFoto">
                                    <h5>
                                    <i class="icon-picture"></i>
                                        Cambiar Foto
                                    </h5>
                                    <p>
                                        <input type="file" name="foto_usuario" class="btn btn-mini" />
                                    </p>
                                </div>
                            </div>
                        </div>     
                        <!-- Primera Columna -->
                        <!-- Nombre DNI Pais Localidad Domicilio Telefono  -->
                        <div class="span3" id="datos_izquierda_1">
                            <!-- Nombre --> 
                            <div class="control-group" >
                                <label class="control-label">Nombre :</label>
                                <span class="rank_help-inline"> *Nombre Inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Nombre" runat="server" />
                                <br />
                            </div>
                            <!-- NIF --> 
                            <div class="control-group">
                                <label class="control-label">NIF :</label>
                                <span class="rank_help-inline"> *NIF inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_NIF" runat="server" />
                                <br />
                            </div>
                            <!-- Pais -->
                            <div class="control-group">
                                <label class="control-label" >País de Residencia :</label>
                                <br />
                                <asp:DropDownList ID="DropDownList_Pais" CssClass="datos_entrada" runat="server">
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
                                <br />
                            </div>
                            <!-- Localidad -->
                            <div class="control-group">
                                <label class="control-label">Localidad :</label>
                                <span class="rank_help-inline"> *Localidad Inválida.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Localidad" runat="server" />
                                <br />
                            </div>
                            <!-- Domicilio -->
                            <div class="control-group">
                                <label class="control-label">Domicilio :</label>
                                <span class="rank_help-inline"> *Domicilio Inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Domicilio" runat="server" />
                                <br />
                            </div>
                            <!-- Telefono -->    
                            <div class="control-group">
                                <label class="control-label">Teléfono :</label>
                                <span class="rank_help-inline"> *Teléfono Inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Telefono" runat="server" />
                                <br />
                            </div>
                            <!-- Sexo -->    
                            <div class="control-group">
                                <label class="control-label">Sexo :</label>
                                <br />
                                <asp:DropDownList ID="DropDownList_Sexo" runat="server" CssClass="datos_entrada">
                                    <asp:ListItem></asp:ListItem>
	                                <asp:ListItem>Hombre</asp:ListItem>
                                    <asp:ListItem>Mujer</asp:ListItem>   
                                </asp:DropDownList>
                            </div>  
                        </div>
                        <!-- Segunda Columna -->
                        <!-- Apellidos Fecha Provincia CP Mail Movil -->
                        <div class="span3" id="datos_derecha_1">
                            <!-- Apellidos -->
                            <div class="control-group">
                                <label class="control-label">Apellidos :</label>
                                <span class="rank_help-inline"> *Apellidos Inválidos.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Apellido" runat="server" />
                                <br />
                            </div>
                            <!-- Fecha de Nacimiento -->
                            <div class="control-group">
                                <label class="control-label">Fecha de Nacimiento :</label>
                                <span class="rank_help-inline"> *Fecha con formato incorrecto. MM/DD/YYYY.</span>
                                <br />
                                <asp:TextBox ID="TextBox_FN" runat="server" />
                                <br />
                            </div>
                            <!-- Provincia -->
                            <div class="control-group">
                                <label class="control-label">Provincia :</label>
                                <br />
                                <asp:DropDownList ID="DropDownList_Prov" runat="server"  CssClass="datos_entrada">
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
                                <br />
                            </div>
                            <!-- CP -->
                            <div class="control-group">
                                <label class="control-label">Código Postal :</label>
                                <span class="rank_help-inline"> *Codigo Inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_CP" runat="server" />
                                <br />
                            </div>
                            <!-- Mail -->
                            <div class="control-group">
                                <label class="control-label">Correo Electrónico :</label>
                                <span class="rank_help-inline"> *Correo Inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Mail" runat="server" />
                                <br />
                            </div>
                            <!-- Movil -->
                            <div class="control-group">
                                <label class="control-label">Móvil :</label>
                                <span class="rank_help-inline"> *Móvil inválido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_Movil" runat="server" />
                                <br />
                            </div>
                        </div>
                    </fieldset>
                    <br />
                    <!-- Cambio de Pass --> 
                    <fieldset class="usuario">
                        <legend>Cambio de Contraseña</legend>
                        <br />
                        <div class="span3">
                            <div class="control-group">
                                <label class="control-label">Nueva Contraseña :</label>
                                <span class="rank_help-inline"> *No Válido.</span>
                                <br />
                                <asp:TextBox ID="TextBox_PASS_3" runat="server" TextMode="Password"/>
                                <br />
                            </div>
                        </div>
                        <div class="span3">
                            <div class="control-group">
                                <label class="control-label">Contraseña anterior :</label>
                                <span class="rank_help-inline"> *No Coinciden.</span>
                                <br />
                                <asp:TextBox ID="TextBox_PASS_1" runat="server" TextMode="Password"/>
                                <br />
                            </div>
                        </div>
                        <div class="span3">
                            <div class="control-group">
                                <label class="control-label">Repita contraseña :</label>
                                <br />
                                <asp:TextBox ID="TextBox_PASS_2" runat="server" TextMode="Password"/>
                                <br />
                            </div>
                        </div>
                    </fieldset>
                    <!-- Botones de Accion --> 
                    <div class="form-actions" id="botonEditar">
                        <asp:Button CssClass="btn btn-primary" ID="bGuardar" runat="server" 
                                    Text="Guardar Cambios" onclick="bGuardar_Click" />
                        <asp:Button ID="bCancel" CssClass="btn" runat="server" Text="Cancelar" 
                                    onclick="bCancelar_Click"/>
                    </div>
                </div>
            </div>
        <!-- Pestaña Historial --> 
            <div class="tab-pane" id="tabCompras">
                <asp:Label CssClass="labels" ID="Label1" runat="server" Text="Prueba de Funcionamiento :D - Pene" ></asp:Label>
            </div>
        </div> 
    </div>
</div>
 
<script type="text/javascript">
 
    /* Javascript de Validaciones */

    $(document).ready(function () {
        $('.rank_help-inline').hide();
        $('#form1').on('submit', function (e) {
            $('.rank_help-inline').hide();
            $('div').removeClass('error');
            if (ValidaFormulario() == false)
                e.preventDefault();
        });
    });

    function ValidaFormulario() {
        var correcto = true;

        var RegExText = /^([a-zA-Z\s]{3,50})$/;
        var RegExDNI = /^(\d{8}[A-Z])$/
        var RegExTel = /^\d{9}$/;
        var RegExCP = /^\d{5}$/;
        var RegExMail = /^(.+\@.+\..+)$/;
        var RegExFecha = /^([0-9]{1,2})\/([0-9]{1,2})\/[0-9][0-9][0-9][0-9]$/;
        var RegExPass = /^([a-zA-Z1-9]{3,50})$/;


        /* BLOQUE IZQUIERDO  Nombre DNI Pais Localidad Domicilio Telefono */

        var Nombre = $('#Content1_TextBox_Nombre');
        var Dni = $('#Content1_TextBox_NIF');
        var Local = $('#Content1_TextBox_Localidad');
        var Dom = $('#Content1_TextBox_Domicilio');
        var Tel = $('#Content1_TextBox_Telefono');

        /* BLOQUE DERECHO  Apellido Fecha Provincia CP Mail Movil */

        var Apellido = $('#Content1_TextBox_Apellido');
        var CP = $('#Content1_TextBox_CP');
        var Movil = $('#Content1_TextBox_Movil');
        var eMail = $('#Content1_TextBox_Mail');
        var Fecha = $('#Content1_TextBox_FN');

        /* Bloque Contraseñas */

        var PNuevo = $('#Content1_TextBox_PASS_3');
        var PViejo = $('#Content1_TextBox_PASS_1');
        var PRepetido = $('#Content1_TextBox_PASS_2');

        // Bloque Derecho
        //alert(Apellido.val());
        //alert(CP.val());
        //alert(Mail.val());
        //alert(Movil.val());

        // Bloque Izquierdo
        /*alert(Nombre.val());
        alert(Dni.val());
        alert(Local.val());
        alert(Dom.val());
        alert(Tel.val());*/

        /* BLOQUE IZQUIERDO  Nombre DNI Pais Localidad Domicilio Telefono */

        if (Nombre.val() == "" || !RegExText.test(Nombre.val())) {
            Nombre.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Nombre");
            correcto = false;
        }

        if (Dni.val() == "" || !RegExDNI.test(Dni.val())) {
            Dni.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail DNI");
            correcto = false;
        }

        if (Local.val() == "" || !RegExText.test(Local.val())) {
            Local.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Local");
            correcto = false;
        }

        if (Dom.val() == "" || !RegExText.test(Dom.val())) {
            Dom.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Domicilio");
            correcto = false;
        }

        if (Tel.val() == "" || !RegExTel.test(Tel.val())) {
            Tel.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Telefono");
            correcto = false;
        }

        /* BLOQUE DERECHO  Apellido Fecha Provincia CP Mail Movil */
        
        if (Apellido.val() == "" || !RegExText.test(Apellido.val())) {
            Apellido.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Apellido");
            correcto = false;
        }
    
        if (CP.val() == "" || !RegExCP.test(CP.val())) {
            CP.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail CP");
            correcto = false;
        }

        if (Movil.val() == "" || !RegExTel.test(Movil.val())) {
            Movil.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Movil");
            correcto = false;
        }
       
        if (eMail.val() == "" || !RegExMail.test(eMail.val())) {
            eMail.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Mail");
            correcto = false;
        }

        if (Fecha.val() == "" || !RegExFecha.test(Fecha.val())) {
            Fecha.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
            //alert("Fail Fecha");
            correcto = false;
        }
        else {
            var fecha2 = Fecha.val().toString();
            var dia;
            var mes;
            var ano;

            dia = fecha2[0] + fecha2[1];
            mes = fecha2[3] + fecha2[4];
            ano = fecha2[6] + fecha2[7] + fecha2[8] + fecha2[9];

            //alert(dia);
            //alert(mes);
            //alert(ano);

            if (comFecha(dia, mes, ano)) {
                Fecha.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
                //alert("Fail Fecha");
                correcto = false;
            }
        }

        //Parte Comprobacion de Contraseña
        // Si no estan vacios
        if (PNuevo.val() != "" || PViejo.val() != "" || PRepetido.val() != "") {

            if (PViejo.val() != PRepetido.val()) {
                PViejo.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
                PRepetido.parent('div.control-group').addClass('error');
                //alert("Fail Fecha");
                correcto = false;
            }

            if (!RegExPass.test(PNuevo.val())) {
                PNuevo.parent('div.control-group').addClass('error').find('.rank_help-inline').show();
                //alert("Fail Fecha");
                correcto = false;
            }

        }
        
        return correcto;
    }

    function comFecha(d, m, a) {
        var error = true;
        // meses dias = 31 ( 1 - 3 - 5 - 7 - 8 - 10 - 12)
        // meses dias = 30 ( 4 - 6 - 9  - 11 )

        if (a >= 1900 && (m < 13 && m > 0) && (d > 0 && d < 32)) {
            if (d > 28) // Conflicto al ser bisiesto?
            {
                if ((m == 4 || m == 6 || m == 9 || m == 11) && d < 31)
                    error = false;
                else if ((m == 7 || m == 5 || m == 3 || m == 1 || m == 8 || m == 10 || m == 12) && d <= 31)
                    error = false;
                else if (m == 2 && Bisiesto(a) && d == 29)
                    error = false;
            }
            else error = false;
        }

        return error;
    }

    function Bisiesto(a) {
        var bisiesto = false;
        if ((a % 4 == 0) && ((a % 100 != 0)) || (a % 400 == 0))
            bisiesto = true;
        return bisiesto;
    }

/* Javascript Copiado a pelo de lo indicado en el CSS de twitter. A saber que hace xD */
    /* ========================================================
    * bootstrap-tab.js v2.0.3
    * http://twitter.github.com/bootstrap/javascript.html#tabs
    * ========================================================
    * Copyright 2012 Twitter, Inc.
    *
    * Licensed under the Apache License, Version 2.0 (the "License");
    * you may not use this file except in compliance with the License.
    * You may obtain a copy of the License at
    *
    * http://www.apache.org/licenses/LICENSE-2.0
    *
    * Unless required by applicable law or agreed to in writing, software
    * distributed under the License is distributed on an "AS IS" BASIS,
    * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    * See the License for the specific language governing permissions and
    * limitations under the License.
    * ======================================================== */


    !function ($) {

        "use strict"; // jshint ;_;


        /* TAB CLASS DEFINITION
        * ==================== */

        var Tab = function (element) {
            this.element = $(element)
        }

        Tab.prototype = {

            constructor: Tab

  , show: function () {
      var $this = this.element
        , $ul = $this.closest('ul:not(.dropdown-menu)')
        , selector = $this.attr('data-target')
        , previous
        , $target
        , e

      if (!selector) {
          selector = $this.attr('href')
          selector = selector && selector.replace(/.*(?=#[^\s]*$)/, '') //strip for ie7
      }

      if ($this.parent('li').hasClass('active')) return

      previous = $ul.find('.active a').last()[0]

      e = $.Event('show', {
          relatedTarget: previous
      })

      $this.trigger(e)

      if (e.isDefaultPrevented()) return

      $target = $(selector)

      this.activate($this.parent('li'), $ul)
      this.activate($target, $target.parent(), function () {
          $this.trigger({
              type: 'shown'
        , relatedTarget: previous
          })
      })
  }

  , activate: function (element, container, callback) {
      var $active = container.find('> .active')
        , transition = callback
            && $.support.transition
            && $active.hasClass('fade')

      function next() {
          $active
          .removeClass('active')
          .find('> .dropdown-menu > .active')
          .removeClass('active')

          element.addClass('active')

          if (transition) {
              element[0].offsetWidth // reflow for transition
              element.addClass('in')
          } else {
              element.removeClass('fade')
          }

          if (element.parent('.dropdown-menu')) {
              element.closest('li.dropdown').addClass('active')
          }

          callback && callback()
      }

      transition ?
        $active.one($.support.transition.end, next) :
        next()

      $active.removeClass('in')
  }
        }


        /* TAB PLUGIN DEFINITION
        * ===================== */

        $.fn.tab = function (option) {
            return this.each(function () {
                var $this = $(this)
        , data = $this.data('tab')
                if (!data) $this.data('tab', (data = new Tab(this)))
                if (typeof option == 'string') data[option]()
            })
        }

        $.fn.tab.Constructor = Tab


        /* TAB DATA-API
        * ============ */

        $(function () {
            $('body').on('click.tab.data-api', '[data-toggle="tab"], [data-toggle="pill"]', function (e) {
                e.preventDefault()
                $(this).tab('show')
            })
        })

    } (window.jQuery);
</script>
</asp:Content>
