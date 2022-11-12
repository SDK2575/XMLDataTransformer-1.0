<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="@* | node()">
    <xsl:copy>
      <xsl:apply-templates select="@* | node()"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="/">
    <File>
      <xsl:for-each select="CUSTOMER_DATA/RECORD_DELIM">
        <Record>
          <POL_PK>
            <xsl:value-of select="POLICY_REC/POL_PK"/>
          </POL_PK>
          <PKG_NAME>
            <xsl:value-of select="POLICY_REC/PKG_NAME"/>
          </PKG_NAME>
          <GUNTHER_PKG_IND>
            <xsl:value-of select="POLICY_REC/GUNTHER_PKG_IND"/>
          </GUNTHER_PKG_IND>
          <PKG_TYPE>
            <xsl:value-of select="POLICY_REC/PKG_TYPE"/>
          </PKG_TYPE>
          <STATE_OF_COV>
            <xsl:value-of select="POLICY_REC/STATE_OF_COV"/>
          </STATE_OF_COV>
          <MULTI_ST_POL_IND>
            <xsl:value-of select="POLICY_REC/MULTI_ST_POL_IND"/>
          </MULTI_ST_POL_IND>
          <POL_NO>
            <xsl:value-of select="POLICY_REC/POL_NO"/>
          </POL_NO>
          <GUNTHER_IND>
            <xsl:value-of select="POLICY_REC/GUNTHER_IND"/>
          </GUNTHER_IND>
          <PRINT_IND>
            <xsl:value-of select="POLICY_REC/PRINT_IND"/>
          </PRINT_IND>
          <xsl:for-each select="LTR_NAME_REC">
            <LTR_NAME_BATCH>
              <xsl:value-of select="LTR_NAME_BATCH"/>
            </LTR_NAME_BATCH>
          </xsl:for-each>
        </Record>
      </xsl:for-each>
    </File>
  </xsl:template>
</xsl:stylesheet>
