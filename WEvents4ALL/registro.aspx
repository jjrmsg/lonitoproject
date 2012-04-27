<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="registro.aspx.cs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Content1" runat="server">

<div id="registro" class="reg" style="height: 475px" >

    <fieldset style="height: 384px; width: 964px">

        <asp:Panel ID="PanelNombre" runat="server">
            <label for="nombre">Nombre:</label>
            <input type="text" name="nom" id="nombre" size="20" maxlength="30" />
            <label for="apellidos">Apellidos:</label>
            <input type="text"" name="apell" id="apellidos" size="40" maxlength="40" />
        </asp:Panel>
        
        <br />

        <asp:Panel ID="PanelUsuario" runat="server">
            <label for="usuario">Usuario:</label>
            <input type="text" name="user" id="usuario" size="20" maxlength="30" />

            <label for="password">Password:</label>
            <input type="password" name="pass" id="password" size="22" maxlength="30" />

            <label for="repetirPassword">Repetir Password:</label>
            <input type="password" name="passR" id="repetirPassword" size="22" maxlength="30" />
        </asp:Panel>

        <br />

        <asp:Panel ID="PanelDatosPersonales1" runat="server">
            <label for="NIF">NIF:</label>
            <input type="text" name="nif" id="NIF" size="10" maxlength="9" />

            <label for="email">Email:</label>
            <input type="text" name="correo" id="email" size="40" maxlength="30"  />

            <label for="fechaN">Fecha de Nacimiento:</label>
            <input type="text" name="fechaNac" id="fechaN" size="18" />
        </asp:Panel>

        <br />

        <asp:Panel ID="PanelPaises" runat="server">
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
        </asp:Panel>

        <br />


        <asp:Panel ID="PanelDatosPersonales2" runat="server">

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
        </asp:Panel>

        <input type="submit" value="Enviar" />

    </fieldset>

</div>



</asp:Content>
