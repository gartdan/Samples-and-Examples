using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

using System.Runtime.Serialization;


namespace IE9LeakRepro.Model
{
    [DataContract]
    public class GraphicItem : IEquatable<GraphicItem>
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public GraphicItem()
        {
            
        }

        /// <summary>
        /// Creates an instance of <see cref="GraphicItem"/>
        /// </summary>
        public GraphicItem(string id, string name, string status, int statusId, int categoryId, Color color)
        {
            this.fqr = id;
            this.bgColor = color;
            this.Name = name;
            this.Status = status;
            this.StatusId = statusId;
            this.CategoryId = categoryId;
        }

        /// <summary>
        /// The Item Reference of the bound values
        /// </summary>
        [DataMember]
        public String fqr { get; set; }

        /// <summary>
        /// Any error from the SummaryItem
        /// example: Device_Offline
        /// </summary>
        [DataMember]
        public Int32 errorCode { get; set; }



        /// <summary>
        /// The background color used to display the bound values
        /// </summary>
        [DataMember]
        public Color bgColor { get; set; }

        /// <summary>
        /// The foreground color used to display the bound values
        /// </summary>
        [DataMember]
        public Color fgColor { get; set; }

        /// <summary>
        /// Flag for if the current user can view the bound values
        /// </summary>
        [DataMember]
        public bool isViewable { get; set; }

        /// <summary>
        /// Flag for if the current user can modify the bound values
        /// </summary>
        [DataMember]
        public bool isChangeable { get; set; }

        /// <summary>
        /// Flag for if the current user can override the bound values
        /// </summary>
        [DataMember]
        public bool isOverrideable { get; set; }

        /// <summary>
        /// Flag for if the bound values are in a normal state
        /// </summary>
        [DataMember]
        public bool isNormalStatus { get; set; }

        /// <summary>
        /// Flag for if the bound values are in alarm
        /// </summary>
        [DataMember]
        public bool isInAlarm { get; set; }

        /// <summary>
        /// The type of view that can display the bound values
        /// </summary>
        [DataMember]
        public String NavigateUrl { get; set; }

        /// <summary>
        /// Event Args to pass to the Change Value Dialog
        /// </summary>
        [DataMember]
        public String ChangeValueArgs { get; set; }

        /// <summary>
        /// Event Args to pass to the Add Temporary Override Dialog
        /// </summary>
        [DataMember]
        public String AddTemporaryOverrideArgs { get; set; }

        /// <summary>
        /// ClassId of the item
        /// </summary>
        [DataMember]
        public int ClassId { get; set; }

        /// <summary>
        /// NodeType of the item
        /// </summary>
        [DataMember]
        public int NodeType { get; set; }

        /// <summary>
        /// Status of the graphic item
        /// </summary>
        [DataMember]
        public String Status { get; set; }

        /// <summary>
        /// Numeric value of the status
        /// </summary>
        [DataMember]
        public int StatusId { get; set; }

        /// <summary>
        /// Numeric value of the object category
        /// </summary>
        [DataMember]
        public int CategoryId { get; set; }

        /// <summary>
        /// Name of the graphic item
        /// </summary>
        [DataMember]
        public String Name { get; set; }

        /// <summary>
        /// error text for graphic item
        /// </summary>
        [DataMember]
        public String ErrorText { get; set; }


        #region IEquatable<GraphicItem> Members

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// For this type of object the list of attrs may not be in the same order, but that is still considered equal.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="obj" /> parameter; otherwise, false.
        /// For this type of object the list of attrs may not be in the same order, but that is still considered equal.
        /// </returns>
        /// <param name="obj">
        /// An object to compare with this object.
        /// </param>
        public bool Equals(GraphicItem obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            bool soFarSoGood =
                Equals(obj.fqr, fqr) &&
                Equals(obj.errorCode, errorCode) &&
                obj.bgColor.Equals(bgColor) &&
                obj.fgColor.Equals(fgColor) &&
                obj.isViewable.Equals(isViewable) &&
                obj.isChangeable.Equals(isChangeable) &&
                obj.isOverrideable.Equals(isOverrideable) &&
                obj.isNormalStatus.Equals(isNormalStatus) &&
                obj.isInAlarm.Equals(isInAlarm) &&
                Equals(obj.NavigateUrl, NavigateUrl) &&
                Equals(obj.ChangeValueArgs, ChangeValueArgs) &&
                Equals(obj.AddTemporaryOverrideArgs, AddTemporaryOverrideArgs);

            // The simple attributes don't match, instances are not equal
            if (!soFarSoGood) return false;


            return soFarSoGood;
            // Performance boost!  We know that each GraphicItemAttribute has to be for a different attribute, 



        }

        #endregion

        #region Object overrides (Equals, GetHashCode)

        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// For this type of object the list of attrs may not be in the same order, but that is still considered equal.
        /// </summary>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// For this type of object the list of attrs may not be in the same order, but that is still considered equal.
        /// </returns>
        /// <param name="other">
        /// An object to compare with this object.
        /// </param>
        public override bool Equals(object other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            if (other.GetType() != typeof(GraphicItem)) return false;
            return Equals((GraphicItem)other);
        }

        /// <summary>
        /// Serves as a hash function. 
        /// </summary>
        /// <returns>
        /// A hash code for the current <see cref="GraphicItem" />.
        /// </returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int result = (fqr != null ? fqr.GetHashCode() : 0);
                result = (result * 397) ^ errorCode.GetHashCode();
                //result = (result * 397) ^ (attrs != null ? attrs.GetHashCode() : 0);
                result = (result * 397) ^ bgColor.GetHashCode();
                result = (result * 397) ^ fgColor.GetHashCode();
                result = (result * 397) ^ isViewable.GetHashCode();
                result = (result * 397) ^ isChangeable.GetHashCode();
                result = (result * 397) ^ isOverrideable.GetHashCode();
                result = (result * 397) ^ isNormalStatus.GetHashCode();
                result = (result * 397) ^ isInAlarm.GetHashCode();
                result = (result * 397) ^ (NavigateUrl != null ? NavigateUrl.GetHashCode() : 0);
                result = (result * 397) ^ (ChangeValueArgs != null ? ChangeValueArgs.GetHashCode() : 0);
                result = (result * 397) ^ (AddTemporaryOverrideArgs != null ? AddTemporaryOverrideArgs.GetHashCode() : 0);
                // NOTE: not adding classId and NodeType here since they are constant for a given FQR.
                return result;
            }
        }

        #endregion

        public override string ToString()
        {
            return string.Format("fqr: {0}, errorCode: {1}, attrs: {2}, bgColor: {3}, fgColor: {4}, isViewable: {5}, isChangeable: {6}, isOverrideable: {7}, isNormalStatus: {8}, isInAlarm: {9}, NavigateUrl: {10}, ChangeValueArgs: {11}, AddTemporaryOverrideArgs: {12}, ClassId: {13}, NodeType: {14}, Status: {15}, StatusId: {16}, CategoryId: {17}, Name: {18}, ErrorText: {19}", fqr, errorCode, "attrs", bgColor, fgColor, isViewable, isChangeable, isOverrideable, isNormalStatus, isInAlarm, NavigateUrl, ChangeValueArgs, AddTemporaryOverrideArgs, ClassId, NodeType, Status, StatusId, CategoryId, Name, ErrorText);
        }
    }
}