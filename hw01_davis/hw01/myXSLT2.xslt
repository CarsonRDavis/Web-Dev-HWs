<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <p><a href="default.html">HW 1</a> > myXML2 Example</p>
        <h1>My Favorite Video Games</h1>
        <table border="1">
          
          <tr bgcolor="#8703b3">
            <th style="text-align:left">Game Name</th>
            <th style="text-align:left">Release Date</th>
            <th style="text-align:left">Developer</th>
            <th style="text-align:left">Consoles</th>
          </tr>

          <xsl:for-each select="VideoGames/Game">
            <tr>
              <td bgcolor="#9791ad"><xsl:value-of select="Name"/></td>
              <td bgcolor="#9791ad"><xsl:value-of select="ReleaseDate"/></td>
              <td bgcolor="#9791ad"><xsl:value-of select="Developer"/></td>
              <td bgcolor="#9791ad"><xsl:value-of select="Consoles"/></td>
            </tr>
          </xsl:for-each>
          
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>