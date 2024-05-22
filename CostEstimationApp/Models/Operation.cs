﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CostEstimationApp.Models
{
    public class Operation
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "SemiFinishedProduct type is required.")]
        [ForeignKey("SemiFinishedProductId")]
        public int SemiFinishedProductId { get; set; }
        public SemiFinishedProduct? SemiFinishedProduct { get; set; }

        [Required(ErrorMessage = "Machine type is required.")]
        [ForeignKey("MachineId")]
        public int MachineId { get; set; }
        public Machine? Machine { get; set; }

        [Required(ErrorMessage = "Worker type is required.")]
        [ForeignKey("WorkerId")]
        public int WorkerId { get; set; }
        public Worker? Worker { get; set; }

        [Required(ErrorMessage = "Tool type is required.")]
        [ForeignKey("ToolId")]
        public int ToolId { get; set; }
        public Tool? Tool { get; set; }

        [Required(ErrorMessage = "Tool type is required.")]
        [ForeignKey("OperationTypeId")]
        public int OperationTypeId { get; set; }
        public OperationType? OperationType { get; set; }

        [Required(ErrorMessage = "MRR is required.")]
        [ForeignKey("MRRId")]
        public int MRRId { get; set; }
        public MRR? MRR { get; set; }


        public decimal LengthBeforeOperation { get; set; }
        public decimal WidthBeforeOperation { get; set; }
        public decimal HeightBeforeOperation { get; set; }

        public decimal LengthAfterOperation { get; set; }
        public decimal WidthAfterOperation { get; set; }
        public decimal HeightAfterOperation { get; set; }

    }
}
