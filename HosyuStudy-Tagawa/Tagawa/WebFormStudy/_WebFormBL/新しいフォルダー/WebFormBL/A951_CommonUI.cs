using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;

namespace WebFormBL
{
    public class A951_CommonUI
    {
        // 各共通設定
        public A950_CommonBL GetCommmonInfo(String rPath, String info, String mode = null)
        {
            // 画面ID取得・設定
            String fileName = Path.GetFileName(rPath);
            String displayid = fileName.Substring(0, 4);
            A950_CommonBL cpb = new A950_CommonBL();
            cpb.DisplayId = displayid;

            // ヘッダーかメニューかにより処理を切り分ける
            switch (info)
            {
                case "header":
                    SetHeaderTitle(cpb);
                    break;
                case "menu":
                    SetMenuContens(cpb, mode);
                    break;
                default:
                    // なにもしない。
                    break;
            }
            return cpb;
        }

        // ヘッダー情報設定
        private void SetHeaderTitle(A950_CommonBL cpb)
        {
            // ヘッダータイトル名を設定
            switch (cpb.DisplayId)
            {
                case "A001":    // トップ画面
                    cpb.DisplayName = "トップ";
                    break;
                case "A011":    // 商品検索画面
                    cpb.DisplayName = "商品検索";
                    break;
                case "A012":    // 商品一覧画面
                    cpb.DisplayName = "商品一覧";
                    break;
                case "A013":    // 商品登録画面
                    cpb.DisplayName = "商品登録";
                    break;
                case "A014":    // 商品編集画面
                    cpb.DisplayName = "商品編集";
                    break;
                default:
                    // なにもしない。
                    break;
            }
        }

        // メニュー情報設定
        private void SetMenuContens(A950_CommonBL cpb, String mode = null)
        {
            // メニュー名設定、表示非表示設定、遷移先URL設定
            switch (cpb.DisplayId)
            {
                case "A001":    // トップ画面から遷移
                    cpb.MenuNameLeft = "商品情報検索";
                    cpb.MenuNameRight = String.Empty;
                    cpb.MenuLeftHide = true;
                    cpb.MenuRightHide = false;
                    cpb.MenuLeftEnab = true;
                    cpb.Url = ".. / A010_Book / A011_BookSerch.aspx";
                    break;
                case "A011":    // 商品検索画面から遷移
                    cpb.MenuNameLeft = String.Empty;
                    cpb.MenuNameRight = "商品情報登録";
                    cpb.MenuLeftHide = false;
                    cpb.MenuRightHide = true;
                    cpb.MenuRightEnab = true;
                    cpb.Url = "A002_Addition.aspx";
                    break;
                case "A012":    // 商品一覧画面、商品登録画面
                case "A013":
                    // メニュー非表示
                    cpb.MenuLeftHide = false;
                    cpb.MenuRightHide = false;
                    cpb.Url = String.Empty;
                    break;
                case "A014":    // 商品編集画面から遷移
                    cpb.MenuNameLeft = "編集";
                    cpb.MenuLeftHide = true;
                    cpb.MenuNameRight = "／参照";
                    cpb.MenuRightHide = true;


                    // 編集／参照リンク活性非活性設定
                    switch (mode)
                    {
                        case "h":   // 編集モード
                            // 編集リンク活性、参照リンク非活性
                            cpb.MenuLeftEnab = false;
                            cpb.MenuRightEnab = true;
                            break;
                        case "s":   // 参照モード及び初期表示
                        default:
                            // 参照モード設定及び編集リンク活性、参照リンク非活性
                            //cpb.Mode = "s";
                            cpb.MenuLeftEnab = true;
                            cpb.MenuRightEnab = false;
                            break;
                    }

                    cpb.Url = "A014_ShouhinUpdate.aspx?Mode=";
                    break;
                default:
                    // なにもしない。
                    break;
            }
        }
    }
}