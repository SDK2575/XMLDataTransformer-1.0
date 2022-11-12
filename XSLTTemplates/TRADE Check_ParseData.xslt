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
      <xsl:for-each select="PAYMENT_DATA/RECORD_DELIM">
        <Record>
          <REPRINT_IND>
            <xsl:value-of select="PAYMENT_REC/REPRINT_IND"/>
          </REPRINT_IND>

          <TYPE_CD>
            <xsl:value-of select="PAYMENT_REC/TYPE_CD"/>
          </TYPE_CD>
          <AUTO_SORTED_BARCODE>
            <xsl:value-of select="PAYMENT_REC/AUTO_SORTED_BARCODE"/>
          </AUTO_SORTED_BARCODE>
          <CHECK_NUM>
             <xsl:value-of select="PAYMENT_REC/CHECK_NUM"/>
          </CHECK_NUM>
          <CHECK_AMOUNT>
            <xsl:value-of select="PAYMENT_REC/CHECK_AMOUNT"/>
          </CHECK_AMOUNT>
          <COMPANY_NAME>            
            <xsl:value-of select="PAYMENT_REC/COMPANY_NAME"/>
          </COMPANY_NAME>

          <PAYMT_METHOD>
            <xsl:value-of select="PAYMENT_REC/PAYMT_METHOD"/>
          </PAYMT_METHOD>
          <ARCHIVE_ONLY_IND>
            <xsl:value-of select="PAYMENT_REC/ARCHIVE_ONLY_IND"/>
          </ARCHIVE_ONLY_IND>

          <xsl:for-each select="PARTIES_DETAIL">

            <xsl:if test="PARTY_ROLE != 'Pay To The Order Of'">
              <COMM_METHOD>
                <xsl:value-of select="COMM_METHOD"/>
              </COMM_METHOD>

              <PARTY_ROLE>
                <xsl:value-of select="PARTY_ROLE"/>
              </PARTY_ROLE>
            </xsl:if>
          </xsl:for-each>

          
        </Record>
      </xsl:for-each>
    </File>
  </xsl:template>
</xsl:stylesheet>
