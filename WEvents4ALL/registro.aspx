<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="WEvents4ALL.registro"%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<div id="registro" class="reg" style="height: 475px" >

<script type="text/javascript">
    function mostrar() {

        var doc = document.getElementById("PanelNombre");

        //doc.style.visibility = "hidden";
        doc.style.display = "none";



        //alert('Estas dentro del Javascript');

    }

    

    </script>

    <fieldset style="height: 384px; width: 964px">

        <div id="PanelNombre" >
            <label for="nombre">Nombre:</label>
            <input type="text" name="nom" id="nombre" size="20" maxlength="30" />

            <label for="apellidos">Apellidos:</label>
            <input type="text"" name="apell" id="apellidos" size="40" maxlength="40" />

            <label for="NIF">NIF:</label>
            <input type="text" name="nif" id="NIF" size="10" maxlength="9" />

            <label for="email">Email:</label>
            <input type="text" name="correo" id="email" size="40" maxlength="30"  />

            <label for="fechaN">Fecha Nac:</label>
            <input type="text" name="fechaNac" id="fechaN" size="18" />
        </div>
        
        <br />

        <div id="PanelUsuario" >
            <label for="usuario">Usuario:</label>
            <input type="text" name="user" id="usuario" size="20" maxlength="30" />

            <label for="password">Pass:</label>
            <input type="password" name="pass" id="password" size="22" maxlength="30" />

            <label for="repetirPassword">Repite Pass:</label>
            <input type="password" name="passR" id="repetirPassword" size="22" maxlength="30" />
       </div>

        <br />

 <!--
        <div id="Paises" >
            <label for="pais">Pais:</label>
            <select name="country" id="pais">
                <option value="España">España</option>
                <option value="Alemania">Alemania</option>
                <option value="Francia">Francia</option>
                <option value="EEUU">Estados Unidos</option>
            </select>

            <label for="provincia">Provincia:</label>
            <select name="provin" id="provincia">
                <option value="Valencia">Valencia</option>
                <option value="Alicante">Alicante</option>
                <option value="Castellon">Castellon</option>
            </select>

            <label for="localidad">Localidad:</label>
            <select name="locali" id="localidad">
                <option value="San Vicente del Raspeig">San Vicente del Raspeig</option>
                <option value="Elda">Elda</option>
                <option value="Elche">Elche</option>
                <option value="Alicante">Alicante</option>
            </select>
        </div>

        <br />


        <div id="PanelDatosPersonales" >

            <div class="direccion">

                <label for="domicilio">Domicilio:</label>
                <input type="text" name="domici" id="domicilio" size="40" maxlength="40" />

                <label for="CP">Código Postal:</label>
                <input type="text" name="cp" id="codigoP" />

                <br />
                <br />

            </div>
            <div class="telefonos">       
                <label for="telefono">Telefono:</label>
                <input type="text" name="tlf" id="telefono" size="14" maxlength="9" />

                <label for="movil">Movil:</label>
                <input type="text" name="mvl" id="movil" size="14" maxlength="9" />
            </div>

            <br />
      
            <label for="hombre">Hombre</label>
            <input type="radio" name="sexo" value="Hombre" id="hombre" />

            <br />

            <label for="mujer">Mujer</label>
            <input type="radio" name="sexo" value="Mujer" id="mujer" />

            <br />
        </div>

     -->

        <input type="submit" value="Enviar" onclick="mostrar()" />

    </fieldset>


</asp:Content>
