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
            <div class="tab-pane active" id="tabPerfil">
                <form id="perfil" class="form-horizontal">             
                    <fieldset class="form-horizontal">
                    <legend>Datos Personales</legend>
                        <br />
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
                            <asp:Label CssClass="labels" ID="Label_Nombre" runat="server" Text="Nombre :" ></asp:Label>
                            <br />
                            <input type="text" name="nombre1" id="nombre" class="datos_entrada"  />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_NIF" runat="server" Text="NIF :" ></asp:Label>
                            <br />
                            <input type="text" name="nombre" id="dni" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_Pais" runat="server" Text="Pa&iacute;s de residencia :" ></asp:Label>
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
                            <asp:Label CssClass="labels" ID="Label_Local" runat="server" Text="Localidad :" ></asp:Label>
                            <br />
                            <input type="text" name="localidad1" id="localidad" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_Dom" runat="server" Text="Domicilio :" ></asp:Label>
                            <br />
                            <input type="text" name="domicilo" id="dom" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_tel1" runat="server" Text="Tel&eacute;fono :"></asp:Label>
                            <br />
                            <input type="text" name="tel1" id="tel1" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_sexo" runat="server" Text="Sexo:" ></asp:Label>
                            <br />
                            <asp:DropDownList ID="DropDownList_Sexo" runat="server" CssClass="datos_entrada">
	                            <asp:ListItem>Hombre</asp:ListItem>
                                <asp:ListItem>Mujer</asp:ListItem>   
                            </asp:DropDownList>
                        </div>
                        <!-- Segunda Columna -->
                        <!-- Apellidos Fecha Provincia CP Mail Movil -->
                        <div class="span3" id="datos_derecha_1">
                            <asp:Label CssClass="labels" ID="Label_Apellido" runat="server" Text="Apellidos :" ></asp:Label>
                            <br />
                            <input type="text" name="apellido" id="apellido" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label1_Fecha" runat="server" Text="Fecha de Nacimiento :" ></asp:Label>
                            <br />
                            <input type="text" name="nombre" id="Text1" class="datos_entrada"/>
                            <br />
                            <asp:Label CssClass="labels" ID="Label_Provincia" runat="server" Text="Provincia :" ></asp:Label>
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
                            <asp:Label CssClass="labels" ID="Label_CP" runat="server" Text="C&oacute;digo Postal :" ></asp:Label>
                            <br />
                            <input type="text" name="cp" id="cp" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_Mail" runat="server" Text="Email:" ></asp:Label>
                            <br />
                            <input type="text" name="mail1" id="mail" class="datos_entrada" />
                            <br />
                            <asp:Label CssClass="labels" ID="Label_tel2" runat="server" Text="M&oacute;vil :"></asp:Label>
                            <br />
                            <input type="text" name="tel2" id="tel2" class="datos_entrada" />
                            <br />
                        </div>
                    </fieldset>
                    <br />
                    <fieldset class="usuario">
                        <legend>Cambio de Contraseña</legend>
                        <div class="span3">
                            <asp:Label CssClass="labels" ID="Label_pass3" runat="server" Text="Nueva Contrase&ntilde;a :" ></asp:Label>
                            <br />
                            <input type="text" name="pass3" id="pass3" class="datos_entrada" />
                            <br />
                        </div>
                        <div class="span3">
                            <asp:Label CssClass="labels" ID="Label_pass" runat="server" Text="Contrase&ntilde;a Anterior :" ></asp:Label>
                            <br />
                            <input type="text" name="pass" id="pass" class="datos_entrada" />
                            <br />
                        </div>
                        <div class="span3">
                            <asp:Label CssClass="labels" ID="Label_pass2" runat="server" Text="Repita Contrase&ntilde;a :" ></asp:Label>
                            <br />
                            <input type="text" name="pass2" id="pass2" class="datos_entrada" />
                            <br />
                        </div>
                    </fieldset>
                    <div class="form-actions" id="botonEditar">
                        <button class="btn btn-primary">
                            <i class="icon-check"></i>
                                Guardar Cambios
                        </button>
                        <button class="btn">
                            <i class="icon-repeat"></i>
                                Cancelar
                        </button>
                    </div>
                </form>
            </div>

            <div class="tab-pane" id="tabCompras">
                <asp:Label CssClass="labels" ID="Label1" runat="server" Text="Prueba de Funcionamiento :D - Pene" ></asp:Label>
            </div>
        </div> 
    </div>
    
</div>
<script type="text/javascript">
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
